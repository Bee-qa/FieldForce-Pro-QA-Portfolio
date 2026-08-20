==========================================================
        MY TERMINAL + GIT COMMANDS CHEAT SHEET
==========================================================

TERMINAL NAVIGATION
----------------------------------------------------------

pwd
→ Shows where I am currently.

dir
→ Shows files/folders in my current location.

cd FolderName
→ Go INTO a folder.

cd ..
→ Go BACK one folder.

cd ../..
→ Go BACK two folders.


MY PORTFOLIO NAVIGATION
----------------------------------------------------------

FROM PORTFOLIO ROOT → API AUTOMATION:

cd API_Automation\RestfulBooker.ApiTests

FROM API AUTOMATION → PORTFOLIO ROOT:

cd ../..

FROM PORTFOLIO ROOT → MANUAL API TESTING:

cd 08_API_Testing

FROM MANUAL API TESTING → PORTFOLIO ROOT:

cd ..

FROM API AUTOMATION → MANUAL API TESTING:

cd ../..
cd 08_API_Testing

FROM MANUAL API TESTING → API AUTOMATION:

cd ..
cd API_Automation\RestfulBooker.ApiTests


API AUTOMATION
----------------------------------------------------------

dotnet test
→ Run all C# NUnit API automation tests.

dotnet test --logger "console;verbosity=detailed"
→ Run tests and show detailed results.

dotnet --version
→ Check installed .NET version.

dotnet --info
→ Show detailed .NET information.


GIT - CHECKING
----------------------------------------------------------

git status
→ Check what files have changed.
→ Also tells me whether I am ahead/behind GitHub.

git remote -v
→ Check which GitHub repository is connected.

git config user.name
→ Check the name being used for Git commits.

git config user.email
→ Check the email being used for Git commits.

git log --oneline
→ See previous commits in a simple format.

q
→ Exit git log if terminal appears stuck.


GIT - SAVING MY WORK
----------------------------------------------------------

git add .
→ Stage ALL changed/new files.

git add filename
→ Stage only one particular file.

git add FolderName
→ Stage a particular folder.

git status
→ Check exactly what is staged BEFORE committing.

git commit -m "My commit message"
→ Save staged changes to LOCAL Git history.

git push origin main
→ Upload my committed changes to GitHub.


NORMAL GIT WORKFLOW
----------------------------------------------------------

1. Check what changed:

git status

2. Stage changes:

git add .

3. Check again:

git status

4. Commit:

git commit -m "Describe what I changed"

5. Push to GitHub:

git push origin main

6. Final check:

git status


EXPECTED FINAL RESULT:

Your branch is up to date with 'origin/main'.
nothing to commit, working tree clean


API AUTOMATION - NORMAL WORKFLOW
----------------------------------------------------------

Go to automation project:

cd API_Automation\RestfulBooker.ApiTests

Run tests:

dotnet test

Go back to portfolio root:

cd ../..

Check changes:

git status

Stage:

git add .

Check staged files:

git status

Commit:

git commit -m "Describe what I changed"

Push:

git push origin main

Final check:

git status


QUICK MEANING
----------------------------------------------------------

cd             = MOVE between folders

pwd            = WHERE am I?

dir            = WHAT is inside this folder?

dotnet test    = RUN my automated tests

git status     = WHAT changed?

git add .      = PREPARE changes

git commit     = SAVE changes locally

git push       = SEND changes to GitHub

git log        = SEE previous commits


IF I GET LOST
----------------------------------------------------------

DO NOT keep typing cd .. randomly.

Run:

pwd

Then:

dir

This tells me:
→ Where I am
→ What folders are available


MY 6 MOST IMPORTANT COMMANDS
----------------------------------------------------------

cd API_Automation\RestfulBooker.ApiTests
dotnet test
git status
git add .
git commit -m "My commit message"
git push origin main


REMEMBER
----------------------------------------------------------

FILES
  ↓
git add .
  ↓
STAGED
  ↓
git commit
  ↓
SAVED LOCALLY
  ↓
git push
  ↓
GITHUB

==========================================================