# Week 1

[TOC]

## Objectives

1. Cloud Computing and its Enablers
   - Cloud Computing
   - Cloud Computing Enablers
2. Cloud Service Models
   - On premises
   - Infrastructure as a Service (Iaas)
   - Platform as a Service (PaaS)
   - Software as a Service (SaaS), XaaS
3. Cloud Deployment Models
   - Public Cloud
   - Private Cloud On-premises
   - Private Cloud Off-Premises
   - Hybrid Cloud

## Cloud Computing Definition

Cloud Computing refers to the creation and use of remote virtual servers or other devices over the Internet instead of local servers or devices.

NIST definition:

_Cloud computing is a model for enabling ubiquitous, convenient, on-demand network access to a shared pool of configurable computing resources (e.g. networks, servers, storage, applications, and services) which can be rapidly provisioned and released with minimal management effort or service provider interaction (Mell & Grance, 2011)_

Two Technologies involved:

- Virtualization
  - Allows for emulation of various type and configurations of computer equipment, using clusters of standardized hardware components.
  - Hypervisor software makes these machines (hosts) run multiple instances of guest virtual machines, sharing resources of the host.
  - Creation and control of virtual machines can be done programmatically.
  - Other IT hardware resources, like storage and network, can also be virtualized
  - _Software implementing server virtualization is call __Hypervisor__._
- Networking
  - Regardless of where the underlying hardware is located, the virtual resources can both be created and accessed remotely, over the Internet
  - The data centers implementing the cloud can be owned and maintained by the cloud providers in separate locations, or organizations on their premises

__Virtualization__ and __Networking(Internet)__ are both the cloud computing enablers, which allow for delivering elastic, on-demand, pay-per-use IT system configurations in the cloud.

## Cloud Service Models

Cloud Service Models differ by what components of the hardware/software stack are maintained and managed by the cloud providers, and which by the customer.

![cloud service models](https://github.com/yasenstar/cloud_computing/blob/master/img/cloud_service_models.png)

On-premises

- In traditional IT "On-premises" model, all components are maintained and managed by the customers
- It also applies to the private cloud delivery model, where an organization maintains an on-premises cloud to take advantage of cloud computing paradigm, but retain full control over their whole stack.

IaaS

- Describes cloud service provider which makes virtualized elements of physical cloud infrastructure - servers, storage, and network - available to the customers. Because the provider implements virtual resources, they also own the virtualization layer.
- After provisioning virtual resources using the provider's Web interface, the customer accesses the user interface screens of these resources over Internet.
- The servers running Windows can be accessed using Microsoft Remote Desktop. Servers running Linux use a Secure Shell command (ssh)
- Customers see the home screen of the OS
- The maintenance of the OS and all the software running on top of it are up to the customer. e.g. middleware (web server), runtime platform (Java JVM), data and application itself

PaaS

- Provides the customer with a complete development environment (platform) in which they can develop and run their own application
- The platform may include programming language editors, compilers, and runtimes, middleware, and development lifecycle supporting tools like requirement maintenance software, design tools, testing and development frameworks, etc.
- Customers and implement complete software development pipeline in the cloud, and even integrate it with IT operations in a paradigm called DevOps (Development and Operations)
- Customer develop applications and provide data for them, and everything else in the image is up to the cloud provider, to license and manage the OS and middleware. The PaaS customer usually sees a console which allows the utilization of various elements of the platform

SaaS / XaaS

- SaaS customers access a particular application package, running in the provider's cloud
- They only see the screens of that application package, and the provider maintains the whole stack including the package
- Also, some providers implement just a particular resources or service access in the cloud like: storage or database, which leads to new acronyms like STaaS or DaaS, and an umbrella model of XaaS (Everything as a Service)

## Cloud Deployment Models

Public Cloud

- Most popular deployment model.
- The physical cloud infrastructure is located on cloud provider's premises, and it is shared by all cloud customers.
- This means your virtual server runs on a physical host on which virtual servers of other customers can also be running. Depending on the loads placed on other customers' virtual servers, the hypervisor may allocate fewer host resources to your virtual server.
- Although no server will be "starved to death", the fluctuations in CPU or memory allocations can be recognizable. They are also referred as "noisy neighbor effect"

Private Cloud

- Private Cloud Off-Premises
  - Organization may demand and get exclusive access to physical resources implementing their cloud. This is called "private cloud." It can happen on or off-premises of the customer..
  - In private off-premises cloud, a cloud customer gets a dedicated physical host on the provider's premises. This is also called a "dedicated cloud" model. The virtual servers of one customer are provisioned on the same or other dedicated hosts.
- Private Cloud On-Premises
  - Because of security or control considerations, some organizations insist on having the physical cloud infrastructure located on their premises.
  - This is the traditional private cloud deployment model, and some vendors also call it a "__local cloud__."
  - In this private cloud, the customer can take advantage of cloud paradigm elasticity and adaptability but retain a higher degree of control.
  - Using on-premises hardware, organizations can outsource cloud creation and management to a third-party vendor, or do it by themselves.
- Examples of virtualization software are: Open Source OpenStack, VMWare vCenter

Hybrid Cloud

- This is a mix of public and private deployment models, this is a very powerful way to utilize the cloud.
- It allows organizations to run
  - Legacy or critical applications on-premises
  - Applications better suited for cloud, like new "born for the cloud" software, backup, or archiving off-premises
- It requires a more advanced network setup to ensure safe and efficient on-off premises communications

___Note: Any of the deployment models above can support any of the service models.___

## Week 1 Reference

Anderson, E. (2014, July 14). *How to explain private, public and hybrid cloud to your spouse*. Retrieved from <https://www.ibm.com/blogs/cloud-computing/2014/07/explain-private-public-hybrid-cloud-spouse/>

Bals, F. (2014, September 26). *Pizza as a Service - On Prem, IaaS, PaaS and SaaS Explained through Pie*. Retrieved from <https://www.linkedin.com/pulse/20140926191127-3354428-pizza-as-a-service-on-prem-iaas-paas-and-saas-explained-through-pie>

Barabas, J. (n.d.). IaaS PaaS SaaS - Cloud Service Models. Retrieved from <https://www.ibm.com/cloud/learn/iaas-paas-saas>

Colman, E. (2013, August 27). *When to use SaaS, PaaS, and IaaS*. Retrieved from <https://www.computenext.com/blog/when-to-use-saas-paas-and-iaas/>

Columbus, L. (2017, April 29).  Roundup Of Cloud Computing Forecasts, 2017. Retrieved from <https://www.forbes.com/sites/louiscolumbus/2017/04/29/roundup-of-cloud-computing-forecasts-2017/#20f6a54831e8>

Goswami, K. (2015, August 21). *How would you explain IaaS, PaaS, SaaS to your Mom?. *Retrieved from <https://www.linkedin.com/pulse/how-would-you-explain-iaas-paas-saas-your-mom-kadamb-goswami>

IntegrantSoftware (2013, July 31). IaaS vs. PaaS vs. SaaS. Retrieved from <https://www.youtube.com/watch?v=KgL3BfAc9Cs>

Intel (n.d.). *Public Cloud vs. Private Cloud vs. Hybrid Cloud*. Retrieved from <https://www.intel.com/content/www/us/en/cloud-computing/cloud-101-video.html>

Leong, Bala, Lowery, and Smith (2017, June 15).  *Magic Quadrant for Cloud Infrastructure as a Service, Worldwide*. Retrieved from <https://www.gartner.com/doc/reprints?id=1-2G2O5FC&ct=150519>

Mell and Grance (2011).  The NIST definition of cloud computing.  Gaithersburg, MD: Computer Security Division, Information Technology Laboratory, National Institute of Standards and Technology. Retrieved from <http://nvlpubs.nist.gov/nistpubs/Legacy/SP/nistspecialpublication800-145.pdf>

Rackspace (n.d.). *The Difference Between Private and Public Cloud*. Retrieved from <https://www.rackspace.com/en-us/cloud/cloud-computing/difference>