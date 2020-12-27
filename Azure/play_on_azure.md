## Ubuntu VM

Virtual Machine name: yasen.ubuntu.01

When upgrading to higher ubuntu, an additional ssh daemon will be started at port '1022'.

Can open the port with e.g.:

`iptable -I INPUT -p tcp --dport 1022 -j ACCEPT`

