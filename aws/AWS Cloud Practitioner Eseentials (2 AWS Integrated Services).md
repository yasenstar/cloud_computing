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

### Why Route 53?

- Amazon Route 53 is a Domain Name System, or DNS, web servcie designed to provide businesses and developers with a reliable and highly scalable way to route end-users to internet applictions.
- Domain Registration
- Global, Hightly Available DNS
- Public and Private DNS Names
- Multiple Routing Algorithms
- Both IPv4 and IPv6
- Integrated with other AWS Cloud Services

### DNS Resolution Strategies

- Simple Routing
- Geo-Location
- Failover
- Weighted Round Robin
- Latency-based
- Multi-value Answer

## 04 Amazon Relational Database Services (RDS)

### Challenges of Relational Databases

- Server Maintenance and Energy Foorprint
- Software Install and Patches
- Database Backups and High Availablity
- Limits on Scalability
- Data Security
- OS Installand Patches

### You can run an RDS instance using the Amazon Virtual Private Cloud or VPC service. When you use an Amazon VPC, you have control over your virtual networking environment

- High Availability with Multi-AZ
- Amazon RDS Read Replicas

	- Asynchronous replication method used
	- Offload read queries from the master DB instance
	- Ideal for read-heavy database workloads
	- Read replica can be promoted to Master if needed

### RDS Use Cases

- Web and Mobile Applications

	- High throughput
	- Massive storage scalability
	- HIgh availability

- E-commerce Applications

	- Low-cost database
	- Data security
	- Full managed solution

- Mobile and Online Games

	- Rapidly grow capacity
	- Automatic scaling
	- Database monitoring

## 05 AWS Lambda

### AWS is an event-driven serverless comput service.

### AWS Lambda is a compute service that lets your run code without provisioning or managing service, AWS Lambda executes your code only 

- Full-Managed serverless compute
- Event-driven execution
- Sub-second metering
- Multiple languages supported

### Benefits fron AWS Lambda

- No Servers to Manage
- Continous Scaling
- Subsecond Metering

### What we can use AWS Lambda?

- You can use it for event-driven computing.
- You can run code in response to events, including changes to an Amazon S3 bucket or an Amazon DynamoDB table.
- You can respond to HTTP requests using Amazon API Gateway.
- You can invoke your code using API calls made using the AWS SDKs.
- You can build serverless applications that are triggered by AWS Lambda functions, and you can automatically deploy them using AWS CodePipeline AWS CodeDeploy.

### What is the first step in getting started with AWS Lambda?

- Upload your code!

## 06 AWS Elastic Beanstalk

### Purpose

- Quickly get application into the cloud
- Quickly have the whole environment ready so developers can start developing the system

### Feature

- Platform as a Service, means you have the whole infrastructure and the whole platform created for you so you can simply put your code over the system as required
- It allows a quick development of your application, Any code that you have previously written on some specific languare can be simply placed over the platform that you have.
- It reduces the management complexity, you don't need to worry about managing the whole system, but, if you wih, you can have full control over that.
- Keeps control in your hands

	- Choose your instance type
	- Choose your database
	- It allows you to adjust Auto Scaling according to your needs.
	- It allows you to update your application
	- access server log files
	- enables HTTPS on the load balancer according to the needs of your application

- It supports a large range of platform, goes from Packet Builder, Single Container or Multicontainer, or Preconfigured Docke. Is supports Go, Java with Tomcat, Java SE, .NET on Windows, Node.js, PHP, Python, and Ruby
- Provide you all the application services, the HTTP service, operating system, language interpreter,and the ost.

	- 

- Update your application as easily as you deployed it

	- 

## 08 Amazon CloudWatch

## 07 Amazon Simple Notification Service (SNS)

## 09 Amazon CloudFront

## 10 AWS CloudFormation

