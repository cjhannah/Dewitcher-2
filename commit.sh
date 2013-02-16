git init
 
# Add the new files
git add .
 
# Clean
git gc
 
# Commit
echo "Type a message for this commit:"
read msg
git commit -m "$msg"
 
# Push
git push -u dewitcher master
read