# Week 2 Cloud Infrastructure

## Objectives

- Virtual Servers
- Bare Metal Servers
- Containers
- Server-less Computing

## Virtual Servers

The data center is controlled by a software management system, which keeps track of all the infrastructure elements and can invoke various operations on them.

The servers in the racks provide the main cloud infrastructure element, commonly called "Compute", which delivers computational power for cloud customers.

### Virtual Server Implementation

Virtualization is a technique allowing computers to emulate other computers as well as various hardware devices.

For server virtualization, __hypervisor__ software can create multiple copies of the emulated (virtual) machines on the host server, and manage them. Each virtual server can run its own (guest) operating system.

The hypervisor can substitute for the host's operating system, or run on top of it.

![virtual server hypervisor types](https://github.com/yasenstar/cloud_computing/blob/master/img/virtual_server_hypervisor.png)

The CPUs of physical host servers in the racks are multi-core which means they contain multiple separate processing units - cores capable of running computer code. Each core may be multi-threaded, allowing execution of several separate threads.

Intel's Hyper-Threading technology allows the hypervisor to see the threads as separate "logical" CPUs. Hypervisors allocate separate core threads (also called virtual CPUs or virtual cores) to virtual servers. They also implement sharing of host server's memory and attached disks among created virtual servers.

Each physical host is equipped with multiple network interface cards (NICs), which can also be virtualized and shared among virtual servers. Add to it virtualization of network devices in the data center (routers and switches, connected to server's NICs), and each virtual server can get its network addresses. Also the fact that servers are inter-connected allows for creating virtual local network (VLANs) of virtual servers.

[Reference Link on "Data Center 101"](http://www.definethecloud.net/category/concepts/data-center-101)

### Virtual Server Provisioning

### Auto-Scaling

### Load Balancing

### Virtual Server Charges

### Scaling in the Cloud

## Bare Metal Servers

### What is Bare Metal Servers?

### Colocation

##  Containers

### What is a Container?

### Advantages and Disadvantages of Containers

##  Server-less Computing

### What is Server-less Computing