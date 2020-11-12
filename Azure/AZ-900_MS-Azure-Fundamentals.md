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

- Public (often referred to as a multi-tenant environment)

	- You use shared infrastructure that is accessible on a public network
	- Pros

		- Beneficial in that it makes it easy and fast to move to the cloud
		- You benefit from the ability to scale quickly and efficiently because the cloud provider has resources already provisioned and ready for your use when needed
		- You can control costs more efficiently because you only pay for the resources you are using.

	- Cons

		- You do give up some control of the infrastructure when using the public cloud.
		- There may be security concerns with operating in the public cloud, you need to have security measures in place to avoid unauthorized access to your application and data
		- It locks you into the specific configuration defined by the cloud provider.

- Private (often referred to as a single-tenant environment)

	- The private cloud model provides many of the benefits of the cloud (things like easy scaling, and elasticity) in a private environment that is dedicated to a single company.
	- 2 of main reasons why companies choose a private cloud are: Privacy and Regulatory concerns

		- Banks
		- Medical Providers
		- Cruise Ship Industry

		  Cruise ships operate in remote areas where Internet access isn't available, but they still want to take advantage of the benefits of the cloud for day-to-day operations of complex ship systems.

	- The bottom linke is that the difference between a public cloud and a private cloud is the privacy of infrastructure and data. It doesn't really matter who owns the infrastructure (company self, or 3rd party hosting provider)
	- Cons

		- You will likely spend as much on IT as you would in a non-cloud environment.
		- Once you offload management of your private cloud to a third-party, you lose control of importnat considerations, such as the security of your data.

- Hybrid

	- In a hybrid cloud environment, you may have an application that is running within the public cloud, yet it accesses data that is securely stored on-premises.
	- Microsoft provides Azure Stack including software and validated hardware to run it, which allows you to run Azure services on-premises.

- Community

	- Similar to a private cloud, but instead of resources being dedicated to a single company, they are dedicated to a community of companies or individuals who manage it together.

## 2. Azure Services

### 2.1 Core Azure architectural components

- Azure Regions

	- Microsoft created boundaries called geographies, a geographies boundary is oftentimes the border of the country.
	- Each geography is broken out into two or more regions
	- When a customer is creating Azure resources, only the region is visible. (The concept of geographies is an internal implementation of Azure that customer don't really have visibility of when using Azure)
	- To ensure that data in Azure is safe from disasters and failures due to possible problems in a particular region, customers are encourgaged to replicate data in multiple regions. (Microsoft guarantees round-trip network performance of 2-milliseconds or less between regions.)

- Availability Zones

	- Availabililty Zones aren't available in all Azure regions.
	- There're at least 3 availability zones within each enabled region
	- Availability zones provide high-availability and fault tolerance, but they may not help you with disaster recovery.
	- Two categories of services that support availability zones: Zone Services and Zone Redundant Services

- Azure Resource Manager (ARM)

	- ARM is a service that runs in Azure, and it's reponsible for all interaction with Azure services.
	- ARM uses declarative syntax.
	- Benefits of ARM

		- ARM allows your to easily deply multiple Azure resources at once.
		- ARM makes it possible to reproduce any deployment with consistent results at any point in the future
		- ARM allows you to create declarative templates for deployment instead of requiring you to write and maintain complex deployment scripts.
		- AMR makes it possible to set up dependencies so that your resources are deployed in the right order every time.

- Resource Groups

	- Logical container for Azure resources. By creating all Azure services associated with a particular application in a single resource group, you can then deploy and manage all of those services as a single entry.
	- Pros

		- You can easily set up deployments using an ARM template.
		- You can name a resource group with an esily-recognizable name so that you can see all Azure resources used in a particular application at a glance

	- An Azure resource can only exist in ONE resource group

### 2.2 Some of Core Products Available in Azure

- Azure Compute

	- Azure Virtual Machines

		- A software-based computer that runs on a physical computer (host)
		- The host computer runs software called a hypervisor that can create and manage one or more VMs, and those VMs are commonly referred to as guests.
		- Availability Set

			- Fault Domains: a logical representation of the physical rack in which a host computer is installed. By default, Azure assigns 2 fault domains to an availability set.
			- Update Domains: are designed to protect you from a situation where the host computer is beting rebooted. When you create ans availability set, Azure creates 5 update domains by default.
			- 

		- Scale Set

			- Scale sets are deployed in availability set automatically
			- Azure Auto-Scale Feature
			- The "Scaling Availability Sets" functinality has been replaced with Scale Sets.

	- Azure App Service
	- Container Offerings in Azure

		- The concept of "Containers" was invented to help with the problem of moving to the cloud while dealing with the complexities of moving to a new environment, and to make it easier to shift applications into new enviornments
		- A Container is created using a zipped version of an application called an Image, and it includes everything the application needs to run. (e.g. including a database engine, a web server, and so on)
		- In order to run an application in a container, a computer needs to have a container runtime installed on it, the most popular container runtime is Docker (by Docker Inc)
		- Each container operates within an isolated environment, which makes containized applications an ideal solution when security is concern.
		- Azure Container Instances (ACI) is a PaaS service that makes it easy to start a container wihtin minimal configuration
		- ACI is designed to work with simple application.
		- If an application is used heavily by many people and that might need to take advantage of scaling, ACI isn't a good choice, instead, Azure's Kubernetes Service (AKS) world by a better choice.

			- Kubernetes is a container orchestration service
			- Kubernetes creates containers in a pod. A pod is a group of related contrainers, and containers within a pod are able to share resources
			- The computer that Kubernetes pods are running on is called a node or a worker.

	- Serverless Computing

- Azure Networking

	- Azure Virtual Network (VNET)
	- Azure Load Balancer
	- Azure Application Gateway

		- A load balancer that's specifically designed to deal with HPPT traffic.

	- VPN Gateway

		- Site-to-Site VPN (S2S): connects your VNET to a single on-premises location. Requires a VPN with public-facing IP address on-premises. A multi-site variant allows you to connect to multiple on-premises locations.
		- Point-to-Site VPN (P2S): Connects one specific on-premises client PC to your VNET. Multiple clients can connect, but each one connects over its own VPN client.
		- VNET-to-VNET: Connects two Azure VNETs to each other. Useful in situations where you have two VNETs in different Azure regions and you want to securely connect them
		- If no need gateway

			- VNET Peering: Establish communication between two Azure VNETs in the same region.
			- Global VNET Peering: Connect VNETs in different Azure regions.

	- Azure Content Delivery Network (CDN)

		- Typically used with images, videos, and other similarly large files
		- A CDN works by storing a cached version of files on a point-of-presense (POP) server that is located on the outside edge of a network.

	- Azure Traffic Manager

		- A domain name system (DNS)-based system that's designed to enhance the speed and reliability of your appication.
		- Routing Rules

			- Priority
			- Weighted
			- Performance
			- Geographic
			- Multivalue
			- Subnet

- Azure Storage

	- Azure Blob Storage

		- Designed for storing unstructured data, including text files, images, videos, documents, and much more.
		- An entity stored in Blob Storage is referred to as a blob.

			- Block blobs: used to store files used by an application
			- Append blobs: lik block blobs, but append blobs are specialized for append operations. Often used to store constantly updated data like diagnostic logs.e
			- Page blobs: used to store virtual hard drive (.vhd) files that are used in Azure virtual machines.

	- Azure Queue Storage
	- Azure Disk Storage
	- Azure Files

- Azure Database

	- Azure SQL Database

		- a PaaS offering for SQL server database hosting
		- Relational Database System: SQL Server, Oracle, PostgreSQL, MySQL
		- In general, relational databases don't offer the capability of scaling out to provide additional copies of your data in multiple regions

	- Azure Cosmos DB

		- NoSQL database system, which you're not locked into a schema for data
		- There're many different NoSQL DB system, and most of them are geared toward a particulsar database model. Microsoft offers a hosted NoSQL DB System in Azure called Cosmos DB

### 2.3 Some of Solutions Available on Azure

- Internet of Things (IoT)

	- Azure IoT Hub
	- Azure IoT Central

- Big Data and Analytics

	- Azure SQL Data Warehouse

		- When you analyze data in SQL Data Warehouse, you run complex SQL queries against the data
		- SQL DWH provide secure authentication, both SQL Server Authentication in the connection string, and Azure AD
		- While data in SQL DWH, it's encrypted using Transparent Data Encryption (TDE) AES-256 encryption.
		- Two Performance Tiers available

			- The Gen1 performance tier measures compute resources in DWH Units (DWU). When you scale Gen1 DWH for more pwer, you add DWUs.
			- The Gen2 tier uses compute DWH Units, or cDWUs. The difference is that Gen2 uses a local disk-based cache in order to improve performance.

		- Way of load data into SQL DWH

			- Queries against the database
			- ADF Compy
			- SQL Server Integration Services
			- Command Line

	- Azure Data Lake Storage
	- Azure HDInsight

- Artificial Intelligence

	- Databricks

		- Databricks: works with 3rd-party ML frameworks to allow you to build ML models
		- Databricks is based on Apache Spark, an open source system for doing computer work in a clustered environment

	- Azure Machine Learning Service
	- Azure Machine Learning Studio

- Serverless Computing

	- Azure Functions
	- Azure Logic Apps
	- Azure Event Grid

### 2.4 Azure Management Tools

- The Azure Portal
- Azure and PowerShell
- Azure CLI
- Azure Advisor

## 3. Security, Privacy, Compliance and Truse

### 3.1 Securing Network Connectivity in Azure

- Azure Firewall: a stateful firewall

	- A centralized hub network that contains the Azure Firewall and a VM that operates as a jumpbox. The firewall exposes a public IP address, but the jumpbox VM does not.
	- One or more additional network (called spoke networks) that don't expose a public IP address.

- DDoS Protection

	- You can add virtual networks from multiple Azure subscriptions to the same DDoS protection plan.
	- During a DDoS event, Standard tier allows you to stream logs to a security information and event management (SIEM) system.

- Network Security Groups (NSG)

	- An NSG contains several built-in rules provided by Azure that are designed to allow your resources in the virtual network to communicate with each other.

### 3.2 Core Azure Identity Services

- Azure Active Directory (AAD)

	- A cloud-based identity service in Azure that can help you to authenticate and authorize users.
	- The core of Azure AD is a directory of users. Each user has an identity that's comprised of a user ID, a password, and other properties.
	- Azure AD B2B allows you to invite guest users to your Azure AD from other businesses.
	- Azure AD B2C allows you to give users access to Azure AD application by signing in with existing accounts such as a Facebook or Google account

- Multi-factor Authentication

	- Free version of Azure AD that everyone with an Azure subscription gets
	- Non-Free: Azure AD Basic
	- Non-Free: Azure AD Premium P1
	- Non-Free: Azure AD Premium P2
	- Conditional Access requires a Premium Plan for Azure AD

### 3.3 Security Tools and Features of Azure

- Azure Security Center

	- Free tier provides general assessment and recommendations for securing your Azure resources and covers only Azure virtual machines and Azure App Service.
	- Standare tier adds coverage of your Azure SQL Databases, MySQL databases, PostgreSQL, and Azure blob storage, as weel as additionalfeatures such as advanced threat detection, analysis from Microsoft Threat Intelligence, and the ability to manage the regulatory compliance

		- Standard Tier is billed by the hour

	- Primary Area

		- Policy & Compliance
		- Resource Security Hygiene
		- Threat Protection

- Azure Key Vault

	- Provides a secure way to store secrets, keys, and certificates

		- Standard Pricing Tier
		- Premium Pricing Tier: keys are stored in hardware security modules (HSMs)

	- Keeping encryption keys in an HSM boundary is required for Federal Information Processing Standard (FIPS) 140-2, so companies that need to maintain compliance with FIPS 140-2 can do so by using the Premium iter of Key Vault

- Azure Information Protection
- Azure Advanced Threat Protection(ATP)

### 3.4 Azure Governance Methodologies

- Azure Policy: allows you to define rules that are applied when Azure resources are created and managed.
- Role-based Access Control (RBAC)

	- 4 elements

		- Security Principal which represents an identity.
		- Role: what defines how the security principal can interact wiht an Azure resource
		- Scope: defines the level at which the roles is applied, and it controls how much control the security principla has
		- Role Assignments

	- RBAC role assignments are additive.
	- RBAC is enforced by Azure Resource Manager (ARM)

- Locks
- Azure Advisor is a best-practice analyzer for Azure resources.

### 3.5 Monitoring and Reporting Options in Azure

- Azure Monitor
- Azure Service Health

### 3.6 Privacy, Compliance, and Data Protection Standards in Azure

- Microsoft Privacy Statement
- Trust Center
- Service Trust Portal (STP)

	- Compliance Manager
	- Audit Reports
	- Data Protection Information
	- Privacy

- Compliance Manager
- Azure Government
- Azure Germany: Physically local data center, operated by a local company named T-Systems International (a subsidiary of Deutsche Telekom)
- Azure China: Physically local data center, operated by a local company named 21ViaNET

## 4. Azure Pricing and Support

### 4.1 Azure Subscriptions

- You can manage your costs in Azure by creating budgets
- Subscription Options

	- Free Trial
	- Pay-As-You-Go
	- Pay-As-You-Go Dev/Test

- Each subscription is associated with a unique identifier called a subscription ID.

### 4.2 Planning and Management of Costs

### 4.3 Support Options Available in Azure

- Support Plan for Azure

	- Basic
	- Developer
	- Standard
	- Professional Direct
	- Premier

- Available Support Channels outside of support plance

	- MSDN Forums

	- Stack Overflow forums

### 4.4 Azure Service Level Agreements

### 4.5 Service Lifecycle in Azure

