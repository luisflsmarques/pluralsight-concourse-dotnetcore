#!/bin/bash

tar -xzvf ./artifact-repository/app.tar.gz -C ./extracted-package
find .
echo 'managed to do this change to the pipeline without needing to update it via fly. just updated source code'
echo 'after source code is updated this script is included in it'
echo 'which means pipeline auto-updates without fly VERY COOL!'