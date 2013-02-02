clear
#############################################
#            dewitcher Framework            #
#               Commit Script               #
#############################################
#      Copyright (C) GruntXProductions      #
#############################################
echo.

echo "#############################################"
echo "#          Initializing Repository          #"
echo "#############################################"
git init
echo.

clear
echo "#############################################"
echo "#            Merging contents...            #"
echo "#############################################"
git pull
echo.

clear
echo "#############################################"
echo "#             Adding content...             #"
echo "#############################################"
git add .
echo.

clear
echo "#############################################"
echo "#   Please type a message for this commit   #"
echo "#############################################"
read msg
git commit -m "$msg"
echo.

clear
echo "#############################################"
echo "#            Uploading content..            #"
echo "#############################################"
git push -u dewitcher master