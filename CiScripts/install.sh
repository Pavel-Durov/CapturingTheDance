#! /bin/sh

# This link changes from time to time. I haven't found a reliable hosted installer package for doing regular
# installs like this. You will probably need to grab a current link from: http://unity3d.com/get-unity/download/archive
echo 'Downloading from https://netstorage.unity3d.com/unity/fc1d3344e6ea/UnityDownloadAssistant-2017.3.1f1.dmg'
curl -o Unity.pkg https://netstorage.unity3d.com/unity/fc1d3344e6ea/UnityDownloadAssistant-2017.3.1f1.dmg

echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /