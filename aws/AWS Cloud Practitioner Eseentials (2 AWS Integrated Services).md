# AWS Cloud Practitioner Eseentials (2 AWS Integrated Services)

## 01 Application Load Balancer

Elastic Load Balanceing (ELB)

### What is Load Balancer

- Classic Load Balancer
- 2nd type Load Balancer: Application Load Balancer

### 2nd Type App LB: Enhanced Features

- Supported Protocols

	- HTTP, HTTPS, HTTP/2, and WebSockets

- CloudWatch Metrics

	- Additional load balance metrics and Target Group metric dimension

- Access Logs

	- Ability to see connection details for WebSocket connections

- Health Checks

	- Insight into target and application health at more granular level

### Additional Features

- Path and Host-based Routing

	- Path-based provides rules that forward requests to different target groups
	- Host-based can be used to define rules that forward requests to different target groups based on host name

		- Enables the abiity to have multiple domains supported by the same load balancer and rout request to target groups based on the domain requested

- Native IPv6 Support in the VPC
- AWS WAF
- Dynamic Ports

	- Amazon ECS intergrated with Application Load Balancer to expose Dynamic Ports utilized by scheduled containers

- Deleting Protection & Request Tracing

	- Request tracing can be used to track HTTP requests from clients to target

### Why use the Application Load Balancer?

- Ability to use contrainers to host your micro-services and route to those applicatons from a single load balancer

### Key Terms

- Listeners: A listener is a process that checks for connection requests, using the protocol and port that you configure. The rules that you define for a listener determine how the load balancer routes requests to the targets in one or mor target groups
- Target: A Target is a destination for traffic based on the established listener rules
- Target Group: Each target group routes requests to one or more registered targets using the protocols and port number specified. A target can be registered with multiple target groups. Health Checks can be configured on a per target group basis.

## 02 Auto Scaling

### Definition: Auto Scaling helps you ensure that you have the correct number of Amazon EC2 instances avaiable to handle the load for your application.

### When you run your application on EC2 instances, it is critical to monitor the performance of your workload using Amazon CloudWatch

- CloudWatch by itself, however, will not add or remove EC2 instances.

### Crtical Questions to Best Practices

- How can I ensure that my workload has enough EC2 resources to meet fluctuating performance requirements? --> Scalability
- How can I automate EC2 resource provisioning to occur on-demand? --> Automation

### Auto Scaling Components

- 1. Launch Configuration (WHAT?)

	- AMI
	- Instance Type
	- Security Groups
	- Roles

- 2. Auto Scaling Group (WHERE?)

	- VPC and Subnet(s)
	- Load Balancer
	- Minimum Instances
	- Maximum instances
	- Desired capacity

- 3. Auto Scaling Policy (WHEN?)

	- Scheduled
	- On-demand
	- Scale-Out Policy
	- Scale-In Policy

## 03 Amazon Route 53

## 04 Amazon Relational Database Services (RDS)

## 05 AWS Lambda

## 06 AWS Elastic Beanstalk

## 08 Amazon CloudWatch

## 07 Amazon Simple Notification Service (SNS)

## 09 Amazon CloudFront

## 10 AWS CloudFormation

