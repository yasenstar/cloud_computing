# Azure Network Infrastructure

[TOC]

## Azure VPN Gateways

Policy-based VPNs

- Support for IKEv1 only
- Use of _static routing_, where combinations of address prefixes from both network control how traffic is encrypted and decrypted through the VPN tunnel. The source and destination of the tunneled networks are declared in the policy and don't need to be declared in routing tables.
- Must be used in specific scenarios that require them, such as for compability with legacy on-premises VPN devices

Route-based VPNs

- Supports IKEv2
- Uses any-to-any (wildcard) traffic selectors
- Can use _dynamic routing protocols_, where routing/forwarding tables direct traffic to different IPSec tunnels.

### VPN Gateway Sizes

SKU:

- Basic
- VpnGw1/Az
- VpnGw2/Az
- VpnGw3/Az

### Required Azure Resources

- Virtual Network
- GatewaySubnet
- Public IP address
- Local network gateway
- Virtual network gateway
- Connection

### Required On-premises Resources

- A VPN device that supports policy-based or route-based VPN gateways
- A public-facing (internet-routable) IPv4 address

===

## Using Azure CLI to Prepare Azure and On-Prem Virtual Networks

### Create Azure-side resource

1. Run this command in Azure Cloud Shell to create the**Azure-VNet-1**virtual network and the**Services**subnet.

Command:

```
az network vnet create \
    --resource-group learn-14e24b35-f9a7-4007-83a4-e492bd96230b \
    --name Azure-VNet-1 \
    --address-prefix 10.0.0.0/16 \
    --subnet-name Services \
    --subnet-prefix 10.0.0.0/24
```

Result:

```
{
  "newVNet": {
    "addressSpace": {
      "addressPrefixes": [
        "10.0.0.0/16"
      ]
    },
    "bgpCommunities": null,
    "ddosProtectionPlan": null,
    "dhcpOptions": {
      "dnsServers": []
    },
    "enableDdosProtection": false,
    "enableVmProtection": false,
    "etag": "W/\"b30ce753-f539-4ae2-aef1-051031084053\"",
    "id": "/subscriptions/f15bafdb-06d3-48f6-a076-b0a4a3173d36/resourceGroups/learn-14e24b35-f9a7-4007-83a4-e492bd96230b/providers/Microsoft.Network/virtualNetworks/Azure-VNet-1",
    "ipAllocations": null,
    "location": "westus",
    "name": "Azure-VNet-1",
    "provisioningState": "Succeeded",
    "resourceGroup": "learn-14e24b35-f9a7-4007-83a4-e492bd96230b",
    "resourceGuid": "2c6bf35d-0c2a-47bb-ab0d-83895299da92",
    "subnets": [
      {
        "addressPrefix": "10.0.0.0/24",
        "addressPrefixes": null,
        "delegations": [],
        "etag": "W/\"b30ce753-f539-4ae2-aef1-051031084053\"",
        "id": "/subscriptions/f15bafdb-06d3-48f6-a076-b0a4a3173d36/resourceGroups/learn-14e24b35-f9a7-4007-83a4-e492bd96230b/providers/Microsoft.Network/virtualNetworks/Azure-VNet-1/subnets/Services",
        "ipAllocations": null,
        "ipConfigurationProfiles": null,
        "ipConfigurations": null,
        "name": "Services",
        "natGateway": null,
        "networkSecurityGroup": null,
        "privateEndpointNetworkPolicies": "Enabled",
        "privateEndpoints": null,
        "privateLinkServiceNetworkPolicies": "Enabled",
        "provisioningState": "Succeeded",
        "purpose": null,
        "resourceGroup": "learn-14e24b35-f9a7-4007-83a4-e492bd96230b",
        "resourceNavigationLinks": null,
        "routeTable": null,
        "serviceAssociationLinks": null,
        "serviceEndpointPolicies": null,
        "serviceEndpoints": null,
        "type": "Microsoft.Network/virtualNetworks/subnets"
      }
    ],
    "tags": {},
    "type": "Microsoft.Network/virtualNetworks",
    "virtualNetworkPeerings": []
  }
}
```

2. Run this command in Cloud Shell to add the**GatewaySubnet**subnet to**Azure-VNet-1**.

Command:

```
az network vnet subnet create \
    --resource-group learn-14e24b35-f9a7-4007-83a4-e492bd96230b \
    --vnet-name Azure-VNet-1 \
    --address-prefix 10.0.255.0/27 \
    --name GatewaySubnet
```

Result:

```
{
  "addressPrefix": "10.0.255.0/27",
  "addressPrefixes": null,
  "delegations": [],
  "etag": "W/\"1a9b33b7-d114-45f3-8ae9-1b6539552f92\"",
  "id": "/subscriptions/f15bafdb-06d3-48f6-a076-b0a4a3173d36/resourceGroups/learn-14e24b35-f9a7-4007-83a4-e492bd96230b/providers/Microsoft.Network/virtualNetworks/Azure-VNet-1/subnets/GatewaySubnet",
  "ipAllocations": null,
  "ipConfigurationProfiles": null,
  "ipConfigurations": null,
  "name": "GatewaySubnet",
  "natGateway": null,
  "networkSecurityGroup": null,
  "privateEndpointNetworkPolicies": "Enabled",
  "privateEndpoints": null,
  "privateLinkServiceNetworkPolicies": "Enabled",
  "provisioningState": "Succeeded",
  "purpose": null,
  "resourceGroup": "learn-14e24b35-f9a7-4007-83a4-e492bd96230b",
  "resourceNavigationLinks": null,
  "routeTable": null,
  "serviceAssociationLinks": null,
  "serviceEndpointPolicies": null,
  "serviceEndpoints": null,
  "type": "Microsoft.Network/virtualNetworks/subnets"
}
```

3. Run this command in Cloud Shell to create the**LNG-HQ-Network**local network gateway.

Command:

```
az network local-gateway create \
    --resource-group learn-14e24b35-f9a7-4007-83a4-e492bd96230b \
    --gateway-ip-address 94.0.252.160 \
    --name LNG-HQ-Network \
    --local-address-prefixes 172.16.0.0/16
```

Result:

```
{- Finished ..
  "bgpSettings": null,
  "etag": "W/\"7bd2ffa9-bda1-436f-872a-b440dd3ef77a\"",
  "fqdn": null,
  "gatewayIpAddress": "94.0.252.160",
  "id": "/subscriptions/f15bafdb-06d3-48f6-a076-b0a4a3173d36/resourceGroups/learn-14e24b35-f9a7-4007-83a4-e492bd96230b/providers/Microsoft.Network/localNetworkGateways/LNG-HQ-Network",
  "localNetworkAddressSpace": {
    "addressPrefixes": [
      "172.16.0.0/16"
    ]
  },
  "location": "westus",
  "name": "LNG-HQ-Network",
  "provisioningState": "Succeeded",
  "resourceGroup": "learn-14e24b35-f9a7-4007-83a4-e492bd96230b",
  "resourceGuid": "23b69e25-119b-499e-bd17-a9e34272874c",
  "tags": null,
  "type": "Microsoft.Network/localNetworkGateways"
}
```

### Create the simulated on-premises network and supporting resources

