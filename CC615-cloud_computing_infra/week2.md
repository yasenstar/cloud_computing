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

![virtualization in a data center](https://github.com/yasenstar/cloud_computing/blob/master/img/virtualization.png)

[Reference Link on "Data Center 101"](http://www.definethecloud.net/category/concepts/data-center-101)

### Virtual Server Provisioning

Cloud vendors usually provide a selection of virtual server sizes, differing by a number of virtual CPUs, amount of memory allocated, and disk or other storage sizes and types. They often offer "T-shirt" (S, M, L, XL, etc.) sizes or various other types and size designations, like server families suited for different kinds of workloads.

In addition to specifying emulated hardware components of the virtual server, you need to specify what OS and possibly other software should be installed there. This is accomplished by specifying the virtual machine image, containing content of (attached or remote) disk storage which contains bootable OS and possibly other software. Vendors provide image libraries with popular operating systems and applications for customers to use.

### Auto-Scaling

For deployment of multiple virtual servers working together in the cloud, cloud vendors usually offer some version of auto-scaling mechanism creation of a server group to which virtual servers may be added or removed depending on a set of conditions, such as:

- Server virtual CPU load
- Network bandwidth usage
- Or time/calendar constrain

[Reference from AWS on "Auto-Scaling"](https://aws.amazon.com/autoscaling)

### Load Balancing

For server groups handling requests form users, cloud vendors provide the __load balancing__ feature; a gateway which splits incoming request among individual servers based on their load, or some balancing algorithm (e.g. "round robin" type, assigning servers in turn). 

Load balancing can be local and confined to a data center, or global distributing workload across data center.

[Reference from Azure on "Load Balancing Services"](https://azure.microsoft.com/en-us/blog/microsoft-azure-load-balancing-services/)

### Virtual Server Charges

Charges for virtual servers are hourly, minute, or pay-per-use basis. When you stop a virtual server, they can be de-allocated, and then the RAM memory and local storage goes away and server charges stop; however, remote storage and other charges will still be incurred. If the server makes use of remote disks, they can be retained, and the instance can be brought back to life, often on a different physical host.

[Reference from AWS pricing](https://aws.amazon.com/pricing/)

### Scaling in the Cloud (Horizontal Scaling)

Ease of virtual server provisioning lends the cloud to utilize the horizontal scaling model, in which when the need for compute for compute power increases, more servers are added, as in auto-scaling. This is the opposite of vertical scaling, where servers running out of capacity are replaced with bigger servers.

Horizontal scaling is one of the tenets of cloud computing and applies to other kinds of resources too.

## Bare Metal Servers

### What is Bare Metal Servers?

Many cloud vendors offer the capability of renting __complete__ physical servers, without virtualization. You will not have virtual "neighbors" on such servers as they are dedicated solely to your needs. While more expensive, such servers allow clients to have full control over them. Many organizations use them for private off-premises clouds, running a dedicated hypervisor and cloud management software on them.

Provisioning bare metal servers may take longer than virtual servers, and billing is usually completed on a monthly basis. When you stop a bare metal server and don't de-allocate it, you continue to be charged for it.

### Co-location



##  Containers

### What is a Container?

### Advantages and Disadvantages of Containers

##  Server-less Computing

### What is Server-less Computing