# AWS Cloud Practitioner Eseentials (3 AWS Architecture)

## The AWS Well-Architected Framework

### Target

- Assess and improve architectures
- Understand how design decisions impact business
- Learn the 5 pillars and design principles

### 5 Pillars

- Security

	- Components

		- Identity and Access Management (IAM)
		- Detective Controls
		- Infrastructure Protection
		- Data Protection

			- Data Classification
			- Encryption
			- Protecting Data at rest
			- Protecting Data in transit
			- Data Backup
			- Data Replication and Recovery

		- Incident Response

	- Design Principles

		- Implement Security at all layers
		- Enable Traceability
		- Apply Principle of Least Privilege
		- Focus on Securing your System, with AWS Shared Reponsibility Model
		- Automate

- Reliability

	- Components

		- Recover from issues/failures
		- Apply best practices in

			- Foundations
			- Change Management
			- Failure Management

		- Anticipate, Respond, and Prevent Failures

	- Design Principles

		- Test Recovery Procedures
		- Automatically Recover
		- Scale Horizontally
		- Stop Guessing Capacity
		- Manage Change in Automation

- Performance Efficiency

	- Components

		- Select Customizable Solutions
		- Review to Continually Innovate
		- Monitor AWS Services
		- Consider the Trade-Offs

	- Design Principles

		- Democratize Advanced Technologies
		- Go Global in Minutes
		- Use a Serverless Architectures
		- Experiment More Often
		- Have Mechanical Sympathy: use the technology approach taht best aligns to what you're trying to achieve

- Cost Optimization

	- Components

		- Use cost-effective resources
		- Matching supply with demand
		- Increase expenditure awareness
		- Optimize over time

	- Design Principles

		- Adopt a Consumption Model
		- Measure Overall Efficiency
		- Reduce Spending on Data Center Operations
		- Analyze and Attribute Expenditure
		- Use Managed Services

- Operational Excellence

	- Components

		- Manage and Automate Changes
		- Respond to Events
		- Define the Standards

## Fault Tolerance and High Availability

### Fault Tolerance

- Feature

	- Ability of a system to remain operational
	- Build-in redundancy of an application's components

- Tools

	- Aamzon Simple Queue Service
	- Amazon Simple Storage Service
	- Amazon Relational Database Service

### Hign Availability

- High Availability, ensures that

	- Systems are generally functioning and accessible
	- Downtime is minimized
	- Minimal human intervention is required
	- Minimal up-front financial investment

- High Availability: On-Premises vs AWS

	- Traditional (on premises)

		- Expensive
		- Only mission-critical applications

	- AWS

		- Multiple servers
		- Availability zones
		- Regions
		- Fault-tolerant services

- High Availability Service Tools

	- Elastic Load Balancers (ELB)

		- Distributes Incoming Traffic (loads)
		- Sends metrics to Amazon CloudWatch
		- Triggers/Notifies: High Latency, Over Utilization

	- Elastic IP Addresses

		- Are static IP addresses
		- Mask failures (if they were to occur)
		- Continues to access applications if an instance fails

	- Amazon Route 53

		- Authoritative DNS Service: Translate domain names to IP addresses
		- Supports

			- Simple routing
			- Latency-based routing
			- Health checks
			- DNS failovers
			- Geo-location routing

	- Auto Scaling

		- Terminates and launches instances
		- Assists with adjusting or modifying capacity
		- Creates new resources on demand

	- Amazon CloudWatch

		- Distributed statistics gathering system
		- Tracks your metrics of your infrastructure
		- Create and use your own custom metrics
		- Used with Auto Scaling

