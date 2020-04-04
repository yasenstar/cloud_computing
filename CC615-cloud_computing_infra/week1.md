# Week 1

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

Cloud computing is a model for enabling ubiquitous, convenient, on-demand network access to a shared pool of configurable computing resources (e.g. networks, servers, storage, applications, and services) which can be rapidly provisioned and released with minimal management effort or service provider interaction (Mell & Grance, 2011)

Two Technologies involved:

- Virtualization
  - Allows for emulation of various type and configurations of computer equipment, using clusters of standardized hardware components.
  - Hypervisor software makes these machines (hosts) run multiple instances of guest virtual machines, sharing resources of the host.
  - Creation and control of virtual machines can be done programmatically.
  - Other IT hardware resources, like storage and network, can also be virtualized
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

