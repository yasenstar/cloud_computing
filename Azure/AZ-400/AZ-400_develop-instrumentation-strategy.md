[TOC]

## Azure Policy

```JSON
{
    "mode": "Indexed",
    "policyRule": {
        "if: {
            "field": "[concat('tags[', parameters('tagName'), ']')]",
            "exists": "false"
        },
        "then": {
            "effect": "deny"
        }
    },
    "parameters": {
        "tagName": {
            "type": "String",
            "metadata": {
                "displayName": "Tag Name",
                "description": "Name of the tag, such as 'environment'"
            }
        }
    }
}
```

## RBAC - Role-Based Access Control

Using RBAC, you can:

- Allow one user to manage VMs in a subscription, and another user to manage virtual networks
- Allow a database administrator (DBA) group to manage SQL databases in a subscription
- Allow a user to manage all resources in a resource group, such as VMs, websites, and virtual subnets
- Allow an application to access all resources in a resource group

Resource Lock: a setting that can be applied to any resource to block modification or deletion.

