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

