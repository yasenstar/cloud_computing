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

1. az network vnet create
2. 