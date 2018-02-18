#! /bin/sh

echo "https://netstorage.unity3d.com/unity/fc1d3344e6ea/MacEditorInstaller/Unity-2017.3.1f1.pkg?_ga=2.124654157.617447808.1518806906-2146109841.1516133558"
curl -o Unity-2017.3.1f1.pkg https://netstorage.unity3d.com/unity/fc1d3344e6ea/MacEditorInstaller/Unity-2017.3.1f1.pkg?_ga=2.124654157.617447808.1518806906-2146109841.1516133558

echo 'Installing Unity.pkg'
sudo -E su $USER -c 'installer -dumplog -package Unity-2017.3.1f1.pkg -target /'