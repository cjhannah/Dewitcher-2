#############################################
#            dewitcher Framework            #
#               Commit Script               #
#############################################
#        Copyright(C) dewitcher Team        #
#############################################

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
# git clean -d -x -n  <= WTF this seems to cause loads of errors on codeplex..

clear
echo "#############################################"
echo "# DONE Initializing Repository              #"
echo "# DONE Merging contents                     #"
echo "# DONE Adding content                       #"
echo "# DONE Cleaning Repository                  #"
echo "#############################################"
echo "#   Please type a message for this commit   #"
echo "#############################################"
read msg
git commit -m "$msg"

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

# End of Script