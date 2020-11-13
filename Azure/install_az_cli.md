## install az cli in linux / ubuntu

Azure cli need nodejs runtime for performing the cli operation.

```
sudo apt install nodejs-legacy
sudo apt install npm
sudo npm install -g azure-cli
```

I have issue of installing `nodejs-legacy` on chromebook.

the `nodejs` is already installed, but cannot further install `nodejs-legacy`

Try alternative way:

```
git clone https://github.com/Azure/azure-xplat-cli.git
cd ./azure-xplat-cli
npm install
bin/azure
```

