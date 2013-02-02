clear
#############################################
#            dewitcher Framework            #
#               Commit Script               #
#############################################
#        Copyright(C) dewitcher Team        #
#############################################

echo "#############################################"
echo "#          Initializing Repository          #"
echo "#############################################"
git init

clear
echo "#############################################"
echo "#            Merging contents...            #"
echo "#############################################"
git pull

clear
echo "#############################################"
echo "#             Adding content...             #"
echo "#############################################"
git add .

clear
echo "#############################################"
echo "#   Please type a message for this commit   #"
echo "#############################################"
read msg
git commit -m "$msg"

clear
echo "#############################################"
echo "#            Uploading content..            #"
echo "#############################################"
git push -u dewitcher master