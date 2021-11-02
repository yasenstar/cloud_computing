# Learning AZ-500

[toc]

## Use PowerShell to create a user account for user: Isabel Garcia

1. Create a password profile object:

   ```powershell
   $passwordProfile = New-Object -TypeName Microsoft.Open.AzureAD.Model.PasswordProfile
   ```

   Note: before and after "=" you can add space

   

2. Set the value of the password within the profile object:

   ```powershell
   $passwordProfile.Password = 'Pa55w.rd1234'
   ```

   

3. Connect to Azure Active Directory:

   ```powershell
   Connect-AzureAD
   ```

   

4. Identify the name of Azure AD tenant:

   ```powershell
   $domainName = ((Get-AzureAdTenantDetail).VerifiedDomains)[0].Name
   ```

   

5. Create a user account for Isabel Garcia:

   ```powershell
   New-AzureADUser -DisplayName 'Isabel Garcia' -PasswordProfile $passwordProfile -UserPrincipalName "Isabel@$domainName" - AccountEnabled $true -MailNickName 'Isabel'
   ```

   

6. List Azure AD users:

   ```powershell
   Get-AzureADUser
   ```



## Use Powershell to cteate the Junior Admins group and add the user accont of Isabel Garcia to the group

1. Create a new security group named Junior Admins:

   ```powershell
   New-AzureADGroup -DisplayName 'Junior Admins' -MailEnabled $false -SecurityEnabled $true -MailNickName JuniorAdmins
   ```

   

2. List the groups in Azure AD tenant:

   ```powershell
   Get-AzureADGroup
   ```

   

3. Obtain a reference to the user account of Isabel Garcia:

   ```powershell
   $user = Get-AzureADUser -Filter "MailNickName eq 'Isabel'"
   ```

   

4. Add the user account of Isabel to the Junior Admins group:

   ```powershell
   Add-AzureGroupMember -MemberUserPrincipalName $user.userPrincipalName -TargetGroupDisplayName "Junior Admins"
   ```

   

5. Verify that the Junior Admins group contains the user account of Isabel:

   ```powershell
   Get-AzADGroupMember -GroupDisplayName "Junior Admins"
   ```



## Use Azure CLI (Bash) to create a user account

1. Identify the name of Azure AD tenant:

   ```bash
   DOMAINNAME=$(az ad signed-in-user show --query 'userPrincipalName' | cut -d '@' -f 2 | sed 's/\"//')
   ```

   

2. Create a user, Dylan Williams, using above domain name:

   ```bash
   az ad user create --display-name "Dylan Williams" --password "Pa55w.rd1234" --user-principal-name Dylan@DOMAINNAME
   ```

   

3. List Azure AD user accounts:

   ```bash
   az ad user list --output table
   ```

   

## Use Azure CLI (Bash) to create the Service Desk group and add the user account of Dylan to the group

1. Create a new security group named Service Desk

   ```bash
   az ad group create --display-name "Service Desk" --mail-nickname "ServiceDesk"
   ```

   

2. List the Azure AD groups

   ```bash
   az ad group list -o table
   ```

   

3. Obtain a reference to the user account of Dylan Williams

   ```bash
   USER=$(az ad user list --filter "displayname eq 'Dylan Williams'")
   ```

   

4. Obtain the objectId property of the user account of Dylan Williams

   ```bash
   OBJECTID=$(echo $USER | jq '.[].objectId' | tr -d '"')
   ```

   

5. Add the user account of Dylan to the Service Desk group

   ```bash
   az ad group member add --group "Service Desk" --member-id $OBJECTID
   ```

   

6. List members of the Service Desk group and verify that it includes the user account of Dylan

   ```bash
   az ad group member list --group "Service Desk"
   ```

   

## Clean up Resources

Remove the resource group:

```powershell
Remove-AzResourceGroup -Name "AZ500LAB01" -Force -AsJob
```



Remove the resource group:

```powershell
Remove-AzResourceGroup -Name "AZ500LAB02" -Force -AsJob
```



## Implement Azure Policy

Create a resource group:

```powershell
New-AzResourceGroup -Name AZ500LAB02 -Location 'East US'
```



List Resource Groups to verify the new resource group was created:

```powershell
Get-AzResourceGroup | format-table
```

