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

Many cloud vendors offer the option of co-location, allowing customers to bring in their physical servers and install them in the vendor's data center. This way, customers can take advantages of the provider's power, cooling, physical security feature, while they own and fully control the hardware. Other devices, e.g. network or storage devices, can also be co-located.

This is usually a process for co-location to adhere to the provider's security measures. Cloud providers allow for co-located resources to connect to their cloud offering. A typical example is co-locating a custom network gateway to provide connectivity between on and off-premises hybrid cloud environments.

##  Containers

### What is a Container?

While each virtual server carries its own guest operating system, containers run on top of single operating system installed on the host server. Containers are computing units which offer a higher level of isolation from each other. Each container is confined to its own namespace. That means it sees only its own file system in memory.

Containers are provisioned for containers images which contain libraries and the run-times needed for running a particular application. They don't contain the operating system binary so they are smaller.

Virtual Machines v.s. Container: the cake has less layers:

![virtual server v.s. container](https://github.com/yasenstar/cloud_computing/blob/master/img/vm_vs_container.png)

### Advantages and Disadvantages of Containers

| Advantages                                                   | Disadvantage                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Creating a container does not involve installing and booting the OS; they can be brought up and down much faster then virtual servers.<br />Container images are smaller and easier to create and use.<br />Container only have one OS: the Host. Since containers are isolated environments, and each can have its own set of libraries and runtimes, they can run without version conflict even with a shared OS.<br />Container technology is gaining popularity and is being offered by most cloud vendors.<br />It is particularly well suited for deployment of micro-services independent application components, each with its development and deployment cycle. | The fact that there is a single shared OS is a limitation.<br />You cannot run Windows and Linux apps in containers on a single host.<br />Also, the security holes in the shared OS can influence all containers on a host. |

##  Server-less Computing

Most lightweight compute option: if you just have a piece of software which you want to run in the cloud as a reaction to some external event, and you don't want to care about provisioning and maintaining servers or containers, you may take advantages of it. It is called FaaS (Function as a Service).

You will have to adhere to a particular way of writing and deploying your code, but the cloud vendor will supply the infrastructure to run it without your intervention, and release it upon completion.

Code to be deployed on server-less compute has to be stateless; which means that no data can survive across its invocations unless it is persisted externally.

Applications best suited for server-less compute are systems handling events coming from a large number of sources which do not require complicated processing, such as IoT software.

[Serverless-Computing wiki](https://en.wikipedia.org/wiki/Serverless_computing)

- AWS offering is called AWS Lambda, [link](https://aws.amazon.com/serverless/)
- Azure calls it Functions, [link](https://azure.microsoft.com/en-us/services/functions/)

===

keep learning...