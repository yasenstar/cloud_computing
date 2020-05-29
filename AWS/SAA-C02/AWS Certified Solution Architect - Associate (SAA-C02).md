# AWS Certified Solution Architect - Associate (SAA-C02)

## About Exam Road

### Architecting

- 1. AWS Certified Solutions Architect - Associate

	- Define a solution using architectural design principles based on customer requirements
	- Provide implementation guidance based on best practices to the organization throughout the lifecycle of the project
	- 130 minutes, 65 questions

- 2. AWS Certified Solutions Architect - Professional

### Developing

- 1. AWS Certified Developer - Associate
- 2. AWS Certified DevOps Engineer - Professional

### Operations

- 1. AWS Certified SysOps Administrator - Associate
- 2. AWS Certified DevOps Engineer - Professional

### Specialty Certifications

- 1. AWS Certified Advanced Networking - Specialty
- 2. AWS Certified Big Data - Specialty

## Domain1 - Design Resilient Architectures (34%)

### Choose reliable/resilient storage

- EC2 Instance Storage

	- Ephemeral volumes
	- Only certain EC2 instances
	- Fixed capacity
	- Disk type and capacity depends on EC2 instance types
	- Application-level durability

- Elastic Block Sotre

  Durable and Attachable storage for EC2 instance

	- Different types

		- General Purpose SSD (gp2)

			- Recommended for most workloads
			- System boot volumes
			- Virtual desktops
			- Low-latency interactive apps
			- Dev and test environments

		- Provisioned IOPS SSD (io1)

			- Critical business applications that require sustained IOPS performance, or more than 10,000 OPS or 160 MiB/s of throughput per volume
			- Large database workloads

		- Throughput Optimized HDD (st1)

			- Streaming workloads requiring consistent, fast throughout at a low price
			- Big data
			- Data warehouses
			- Log processing
			- Cannot be a boot volume

		- Cold HDD (sc1)

			- Throughput-oriented storage for large volumes of data that is infrequently accessed
			- Scenarios where the lowest storage cost is important
			- Cannot be a boot volume

	- Encryption
	- Snapshots
	- Provisioned capacity
	- Independent lifecycle than EC2 instance
	- Multiple volumes striped to create large volumes

- Amazon EFS (Elastic File System)

	- File storage in the AWS Cloud
	- Shared storage
	- Petabyte-scale file system
	- Elastic capacity
	- Supports NFS v4.0 and 4.1 (NFSv4) protocol
	- Compatible with Linux-based AMIs for Amazon EC2

- Amazon S3

	- Consistency model
	- Storage classes & Durability - Standard, Standard-IA
	- Encryption (data at rest) - SSE-S3, SSE-KMS, SSE-C
	- Encryption (data in transit) - HTTPS
	- Versioning
	- Access control
	- Multi-part upload
	- Internet-API accessible
	- Virtually unlimited capacity
	- Regional Availability
	- Highly Durable - 11 9, 99.999999999%

- Amazon Glacier

	- Data backup and archive storage
	- Vaults and archives
	- Retrievals - expedited, standard, bulk
	- Encryption, by default
	- Amazon S3 object lifecycle policy
	- Regionally availability
	- Highly durable - 99,999999999%

### Determine how to design decoupling mechanisms using AWS services

### Determin how to design a multi-tier architecture solution

### Determine how to design high availability and/or fault tolernt solutions

## Domain2 - Define Performance Architectures (24%)

## Domain3 - Specify Secure Applications and Architectures (26%)

## Domain5 - Define Operationally Excellent Architectures (10%)

## Domain4 - Design Cost-Optimized Architectures (6%)

