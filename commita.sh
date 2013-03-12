clear
echo "#############################################"
echo "#            dewitcher Framework            #"
echo "#               Commit Script               #"
echo "#############################################"
echo "#        Copyright(C) dewitcher Team        #"
echo "#############################################"
echo "#         Press any key to continue         #"
read

clear
echo "#############################################"
echo "#          Initializing Repository          #"
echo "#############################################"
git init

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "#############################################"
echo "#            Merging contents...            #"
echo "#############################################"
git pull

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "# DONE Merging contents                     #"
echo "#############################################"
echo "#             Adding content...             #"
echo "#############################################"
git add .

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "# DONE Merging contents                     #"
echo "# DONE Adding content                       #"
echo "#############################################"
echo "#            Cleaning Repository            #"
echo "#############################################"
# nothing to do
# please use clean.sh

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "# DONE Merging contents                     #"
echo "# DONE Adding content                       #"
echo "# DONE Cleaning Repository                  #"
echo "#############################################"
echo "#   Please type a message for this commit   #"
echo "#############################################"
git commit -a

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "# DONE Merging contents                     #"
echo "# DONE Adding content                       #"
echo "# DONE Cleaning Repository                  #"
echo "# DONE Committing changes                   #"
echo "#############################################"
echo "#            Uploading content..            #"
echo "#############################################"
git push -u dewitcher master

echo.
echo "#############################################"
echo "#                   Done!                   #"
echo "#############################################"
read

# End of Script