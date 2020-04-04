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

