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

   

4. 