# Azure Solutions Architect Expert

## Skills Measured

### Deploy and Configure Infrastructure

### Implement Workloads and Security

### Create and Deploy Apps

### Implement Authentication and Secure Data

### Develop for the Cloud and for Azure Storage

### Determine Workload Requirements

### Design for Identity and Security

### Design a Data Platform Solution

### Design a Business Continuity Strategy

### Design for Deployment, Migration, and Integration

### Design an Infrastructure Strategy

## AZ-300: Microsoft Azure Architect Technologies

### Retired in Sept 2020

### 1. Architect Great Solutions in Azure

Security: Safeguarding access and data integrity and meeting regulatory requirements
Performance and scalability: Efficiently meeting demand in every scenario
Availability and recoverability: Minimizing downtime and avoiding permanent data loss
Efficiency and operations: Maximizing maintainability and ensuring requirements are met with monitoring

- Pillars of a great Azure Architecdture

	- The architecture of a system must balance and align the business requirements with the technical capabilities needed to execute those requirements. Including an evaluating of risks, cost and capabilities throught the system and its components
	- 1. Security

		- Must think about security throughout the entire lifecycle of your application, from design and implementation to deployment and operations
		- Possible security risks

			- Exposed Credentials
			- Network Attacks
			- App Vulnerability
			- Phishing
			- Malware

		- Defense in Depth (Multilayered Approach)

			- Data
			- Applications
			- VM/Compute
			- Networking
			- Perimeter
			- Policies & Access
			- Physical Security

		- Security is more than just technology, it's also about people and processes.
		- Common Attacks

			- Data Layer: Exposing an encryption key or using weak encryption can leave your data vulnerable should unauthorized access occur
			- Application Layer: Malicious code injection and execution are the hallmarks of application-layer attacks. Common attacks include SQL injection and cross-site scripting (XSS)
			- VM/Compute Layer: Malware is a common method of attacking an environment, which involves executing malicious code to compromise a system. Once malware is present on a system, further attacks leading to credential exposure and lateral movement throughout the environment can occur
			- Networking Layer: Unnecessary open ports to the Internet are a common method of attack. These could include leaving SSH or RDP open to virutal machines. When open, these cloud allow brute-force attacks against your systems as attackers attempt to gain access
			- Perimeter Layer: Denial-of-Service (DoS) attacks are ofter seen at this layer. These attacks attempt to overwhelm network resources, forcing them to go offline or making them incapable of responding to legitimate requests
			- Policies & Access Layer: This is where authentication occurs for your application. This cloud  include modern authentication protocols such as OpenID Connect, OAuth, or Kerberos-based authentication such as Active Directory. Exposed credentials are a risk here and it's important to limit the permissions of identities. We also want to have monitoring in place to look for possible compromised accounts, such as logins coming form unusual places.
			- Physical Layer: Unauthorized access to facilities through methods such as door drafting and theft of security badges can be seen at this layer.

		- Shared Security Responsibility

			- 

	- 2. Performance and Scalability

		- It is important for your architecture to have the ability to adjust to demand as well
		- Scaling

			- Scaling Up: the action of adding more resources to a single instance, reverse is Scaling Down
			- Scaling Out: the action of adding more instances, reverse is Scaling In

		- Perfomance Optimization

			- Look at netowrk and storage to ensure performance is acceptable
			- Als include understanding how the applications themselves are performing

		- Patterns of Scalability and Perofrmance

			- Data Partitioning: Improve scalability, reduce contention, and optimize performance
			- Caching: Improve performance
			- Autoscaling: dynamically allocating resources to match performance requirements, takes advantages of the elasticity of cloud-hosted environments while easing management overhead.
			- Decouple resource-intensive tasks as background jobs: minimize the load on the application UI, which can improve availability and reduce interactive response times
			- Performance monitoring: use this information as a diagnostic aid to detect and correct issues, and also to help spot potential problems and prevent them from occuring

	- 3. Availability and Recoverability

		- Designing for Availability focuses on maintaining uptime through small-scale incidents and temporary conditions like partial network outages.

			- Idetify the SLA you're committing to.
			- RPO
			- RTO

		- Designing for Recoverability focuses on recovery from data loss and from larger scale disasters.

	- 4. Efficiency and Operations

		- Efficiency: focus on identifying and eliminating waste within your environment

			- Look at cost optimization steps like siazing VMs properly and deallocating VMs that aren't in use
			- Move from IaaS to PaaS services

		- Operational Best Practices

			- Automate as much as possible
			- Have a thorough monitoring, logging, and instrumentation system
			- Designed with DevOps and continoous integration in mind

	- Shared Responsibiity

		- 

- Design for security

	- Defense in Depth
	- Identity Management
	- Infrastructure Protection
	- Encryption
	- Network Security
	- Application Security

- Design for performance and scalability
- Design for availability and recoverability
- Design for efficiency and operations

### 2. Architect Network Infrastructure in Azure

### 3. Architect Storage Infrastructure in Azure

### 4. Architect Compute Infrastructure in Azure

### 5. Architect Infrastructure Operations in Azure

### 6. Architect a Data Platform in Azure

### 7. Architect Message Brokering and Serverless Applications in Azure

### 8. Architect Modern Applicataions in Azure

### 9. Architect API Integration in Azure

## AZ-303: Microsoft Azure Architect Technologies (Beta)

### Will be available from Jun 29 2020

### US$165

## AZ-301: Microsoft Azure Architect Design

## AZ-304: Microsoft Azure Architect Design (Beta)

