# AZ-900_MS-Azure-Fundamentals

## 1. Cloud Concepts

One of the primary benefits for moving to the cloud is removing some of the IT burden from your own company.

### 1.1 Benefits and Considerations of Using Cloud Services

- High Availability

	- Network Outage
	- Application Failure

		- Software Bug
		- Application Design

	- System, such as a VM, Outage
	- Power Outage
	- Problem with a Reliant System such as External Databases

- Scalability, Elasticity and Agility

	- Scaling is the process of adding additional resources or additional power for your application

	  In addition to Scaling Out and Scaling Up, you can also Scaling In and Scaling Down to decrease resource usage.

		- Horizontal Scaling (Scaling Out): add additional VMs for application, each VM you add is identical to other VMs servicing your application
		- Vertical Scaling (Scaling Up): move to a new VM with additional resources.

	- The conecpt of automatically scaling is referred to as Elasticity

		- In Azure, you can scale automatically by configuring Auto-Scale
		- One of major benefits of the cloud is that it allows you to quickly scale.

	- The speed and flexibility of scaling in the cloud is call ed Cloud Agility

- Fault Tolerance and Disaster Recovery

	- Fault Tolerance v.s. Scaling

		- Scaling allows you to react to additional load or resource needs, but it's always assumed that all of the VMs you are using are healthy.
		- Fault Tolerance happens without any interaction from you, and it's designed to automatically move you from an unhealthy system onto a healthy system in the event that things go wrong.s

	- Fault Tolerance is designed to deal with failure at a small scale; moveing you, e.g. from an unhealthy VM to a healthy VM.
	- Disaster Recovery not only means having reliable backups of important data, but it also means that the cloud infrastructure can replicate your application's resources in an unaffected region so that your data is safe and your application availaibility isn't impacted.

- Principles of Economies of Scale

	- Differences between Capital Expenditures (CaPEX) and Operations Expenditures (OPEX)

		- Capital Expenditures (On-Premises Model)

			- Hardware will be outdated long before it makes financial sense to replace it.
			- It is not an agile approach.

		- Operating Expenditures (Cloud Model)

			- Unlike Capex, the Opex are tracked on a month-by-month basis, so it's much easier to adjust them based on need
			- The cloud model is also reducing the costs, from the cloud providers' principle of economies of scale.

	- Consumption-Based Model

		- The ability to use only those cloud based computing resources you require at any particular time.

### 1.2 Differences between IaaS, PaaS and SaaS

- IaaS refers to the virtualized infrastructure offered by a cloud provider, you control the OS install and installation of other services.

	- [Pro] IaaS provides you with the greatest flexibility
	- [Pro] You pay for your resources only when they're being used, so IaaS has the ability to reduce your operational expenses.
	- [Con] Even though you can save costs by turning off VMs you aren't using, the higher costs associated with installing and maintaining your VMs might offset that benefit.

- In a PaaS environment, a cloud provider still provides the infrastructure for you, but they also provide the OS, software installed in the OS to help you connect to databases and network systems (oftern referred to as middleware), and many features that enable you to build and manage complex cloud applications.

	- [Pro] PaaS offer you some of the same flexibility of IaaS service without the need to manage the instratructure.
	- [Pro] PaaS services are popular for developer teams who are looking to move on-premises application to the cloud easily and quickly.
	- [Pro] PaaS offer more features than IaaS, because the cloud provider installs their own software and features on the platform
	- [Con] Any application running in a PaaS service can be impacted by updates and version changes in the underlying software, that can mean increased costs associated with testing an application before the cloud provider rolls out changes

- SaaS is software provided by a cloud provider that's installed on infrastructure completely controlled by the hosting provider, offer you the flexibility of a pay-as-you-go model

	- [Pro] SaaS largely removes the IT burden from your company, and it enables everyone in your company to access the software on multiple devices from just about anywhere Internet access is available
	- [Pro] You benefit from data backup that the cloud provider includes in their infrastructure.
	- [Con] If you have a need to customize the application or have any control over its configuration, however, SaaS may not be a good choice for you.

### 1.3 Differences between Public, Private and Hybrid Cloud Models

## 2. Azure Services

### 2.1 Core Azure architectural components

### 2.2 Some of Core Products Available in Azure

### 2.3 Some of Solutions Available on Azure

### 2.4 Azure Management Tools

## 3. Security, Privacy, Compliance and Truse

### 3.1 Securing Network Connectivity in Azure

### 3.2 Core Azure Identity Services

### 3.3 Security Tools and Features of Azure

### 3.4 Azure Governance Methodologies

### 3.5 Monitoring and Reporting Options in Azure

### 3.6 Privacy, Compliance, and Data Protection Standards in Azure

## 4. Azure Pricing and Support

### 4.1 Azure Subscriptions

### 4.2 Planning and Management of Costs

### 4.3 Support Options Available in Azure

### 4.4 Azure Service Level Agreements

### 4.5 Service Lifecycle in Azure

