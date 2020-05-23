# AWS Cloud Practitioner Eseentials (5 AWS Pricing and Support)

## Fundamentals of Pricing

### With AWS, you pay only for the individual services you need, for as long as you use them, and without signing up for long-term contracts or complex licensing.

- Pay as you go
- Pay less when you reserve
- Pay even less per unit by using more
- Pay even less as AWS grows

### Type

- Pay-as-you-go
- Paying for services on an as-needed basis

	- All up-front (called AURI)
	- No upfront payment (called NURI)

- Free usage tier for new customers

## Pricing Details

### AWS Cost Fundamentals

- Pay for

	- Compute capacity
	- Storage
	- Outbound data transfer (aggregated)

- No charge for inbound data transfer

### Amazon EC2, web service that

- What

	- Provides resizable compute capacity in the cloud
	- Allows the configuration of capacity with minimal friction
	- Provides complete control

- Charges only for capacity used

	- Clock-second/hourly billing: resources incur charges only when running
	- Instance configuration

		- Physical capacity of the instance
		- Pricing varies with AWS region, OS, instance type, instance size

- Purchase types

	- On-demand instances

		- Compute capacity by the hour and second
		- Minimum of 60 seconds

	- Reserved instances

		- Low or no up-front payment instances reserved
		- Discount on hourly charge for that instance

	- Spot instances

		- Bid for unused Amazon EC2 capacity

- Other Considerations

	- # of instances: Privision multiple instances
	- Load balancing

		- Use Elastic Load Balacing to distribute traffic
		- Monthly cost based on hours load balancer runs, and data load balancer processes

- Product Options

	- Monitoring

		- Use Amazon CloudWatch to monitor instances
		- Basic monitoring (default)
		- Detailed monitoring (fixed rate, prorated partial months)

	- Auto Scaling

		- Automatically adjusts number of instances
		- No additional charge

	- Elastic IP Addresses: no charge when associated with a running instance

- OS & software

	- OS prices included in instance prices
	- Software

		- Partnership with other vendors
		- Vendor licenses required
		- Existing licenses accepted through specific vendor programs

### Amazon S3

- Object storage built to store and retrieve any amount of data from anywhere
- Provides

	- Durability, availability, and scalability
	- Comprehensive security and compliance capabilities
	- Query in place
	- Flexible management and data transfer
	- Compatibility - supported by partners, vendors, and AWS services

- Storage Classes

	- Standard Storage

		- 99.999999999% durability
		- 99.99% availability

	- Standard-Infrequent Access (S-IA)

		- 99.999999999% durability
		- 99.9% availability

	- Storage cost

		- Number and size of objects
		- Type of storage

- Cost Factors, pricing based on

	- Requests

		- Number of requests
		- Type of requests - different rates for GET requests

	- Data transfer: amount of data transferred out of the Amazon S3 region

### Amazon EBS (Elastic Block Store)

- What

	- Block-level storage for instances
	- Volumes persist independently from the instance
	- Analogous to virtual disks in the cloud
	- 3 volume types: General Prupose (SSD), Provisioned IOPS (SSD), Magnetic

- Cost factors

	- Volumes: All types charged by the amount provisioned in GB per month
	- IOPS

		- General Purpose (SSD): included in price
		- Magnetic: charged by the number of requests
		- Provisioned IOPS (SSD): charged by the amount you provision in IOPS

	- Snapshots: added cost per GB-month of data stored
	- Data Transfer

		- Inbound data transfer has no charge
		- Outbound data transfer charges are tiered

### Amazon RDS

- What

	- Relational database in the cloud
	- Cost-efficient and resizable capacity
	- Management of time-consuming administrative tasks

- Cost Factors

	- Clock-hour billing: resources incur charges when running
	- Database characteristics: Engine, size, and memory class impacts cost
	- DB Purchase Type

		- On-demand database instances are charged by the hour
		- Reserved database instances require up-front payment for database instances reserved
		- Provision multiple DB instances to handle peak loads

	- Provisioned Storage

		- No charge for backup storage of up to 100% of database storage
		- Backup storage for terminated DB instances billed at GB/month

	- Additional storage: backup storage in addition to provisioned storage billed in GB/month
	- Deployment type

		- Storage and I/O charges variable
		- Single availability zones
		- Multiple availability zones

	- Data Transfer

		- No charge for inbound data transfer
		- Tiered charges for outbound data transfer

### Amazon CloudFront

- What

	- Web Service for Content Delivery
	- Integration with other AWS services

		- Low latency
		- High data transfer speeds
		- No minimum commitments

- Cloud Factors

	- Pricing varies across geographic regions
	- Based on Requests, Data Transfer Out

## AWS Trusted Advisor

### Keeping track of your AWS resources

### Trusted Advisor provies best practices (or checks) in 4 categories

- Cost optimization
- Performance
- Security
- Fault Tolerance

