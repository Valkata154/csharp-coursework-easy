# Introduction

You are required to create the presentation layer of a system that is being constructed using the 3
layer architecture as described in the lecture.

**Student Records System.**

The system should have a main window, which accepts the following fields:
![image](https://user-images.githubusercontent.com/45520042/67532569-a3923d00-f6be-11e9-8aa1-542145d9ccb1.png)

The main window should have the following buttons:
![image](https://user-images.githubusercontent.com/45520042/67532598-bf95de80-f6be-11e9-8a8d-ece570b95429.png)

# Tasks

1. Create a WPF project that contains a form with appropriate controls for entering the student
data.

2. Create the clear button and ensure that it clears any input data from the window.

3. Create the validate button and ensure that it validates the fields as set out above, displaying
appropriate error messages. Consider the following

         • Create a validate() method in c# that contains all of the validation code.

         • Have the validate() method return true/false depending on whether the data has been validated

         • Have a message that is displayed when the validate button is pressed and no
         validation errors have been noted.

4. Hide the country field unless the student is an international student

5. Validate the email field as follows:
If not blank than the email address must contain an ‘@’ symbol. The first and last characters
should be in the range 0-9 a-z A- Z

# Images

**Before Entering Details**
![before](https://user-images.githubusercontent.com/45520042/67558273-9735d080-f70e-11e9-912d-e205b49becd3.png)

**After Entering Details**
![after](https://user-images.githubusercontent.com/45520042/67558284-9a30c100-f70e-11e9-8b41-49331d9c676a.png)
