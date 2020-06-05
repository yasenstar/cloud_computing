# Kubernetes_Cookbook

## 1. Building Your Own Kubernetes

### 1.1 Exploring Architecture

- Kubernetes is an Open Source container management tool. It is a Go-Lang based, lightweight, and portable application.
- You can set up a Kubernetes cluster on a Linux-based OS to deploy, manage, and scale the Docker container applications on multiple hosts.
- Kubernetes components

	- Kubernetes Master: connects to etcd via HTTP or HTTPS to store the data, also connects flannel to access the container application.

		- Key components

			- Authorization and authenticaton
			- RESTful API entry point
			- Container deployment schedule to the Kubernetes nodes
			- Scaling and replicating the controller
			- Read and store the configuration
			- Command Line Interface

		- dasmon processes

			- kube-apiserver
			- kube-scheduler
			- kube-controller-manager
			- kubectl

	- Kubernetes Nodes: connect to the Kubernetes Master via HTTP or HTTPS to get a command and report the status.
	- etcd
	- flannel (Overlay Network): Kubernetes notes use an overlay network (e.g. flannel) to make a connection of their container applications

- Building Environment

	- Building datastore (etcd): on Deepin

		- $ sudo apt install etcd
正在读取软件包列表... 完成
正在分析软件包的依赖关系树       
正在读取状态信息... 完成       
将会同时安装下列软件：
  etcd-client etcd-server pipexec
下列【新】软件包将被安装：
  etcd etcd-client etcd-server pipexec
升级了 0 个软件包，新安装了 4 个软件包，要卸载 0 个软件包，有 0 个软件包未被升级。
需要下载 9,852 kB 的归档。
解压缩后会消耗 40.2 MB 的额外空间。


### 1.2 Preparing your Environment

### 1.3 Building Database

### 1.4 Creating an Overlay Network

### 1.5 Configuring Master

### 1.6 Configuring Nodes

### 1.7 Running your first Container in Kubernetes

## 2. Walking through Kubernetes Concepts

## 3. Playing with Containers

## 4. Building a High Availability Cluser

## 5. Building a Continuous Delivery Pipeline

## 6. Building Kubernetes on AWS

## 7. Advanced Cluster Administration

## 8. Logging and Monitoring

