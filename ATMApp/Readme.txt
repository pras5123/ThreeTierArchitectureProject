Issue faced and solution : 

1. allow only number and back space : keypress event established
2. Error : 
Error	19	Could not copy "obj\x86\Debug\ATMApp.exe" to "bin\Debug\ATMApp.exe". Exceeded retry count of 10. Failed.	ATMApp
Error	20	Unable to copy file "obj\x86\Debug\ATMApp.exe" to "bin\Debug\ATMApp.exe". The process cannot access the file 'bin\Debug\ATMApp.exe' because it is being used by another process.	ATMApp

Reason :Although you Hide() your forms, they still remain as a part of the process. 
If you don't close every form properly, the process will remain running and you cannot recompile your project and eventually you will have to
kill your process using the taskmanager. Happened due to no proper disposing of the class
Source of the error : this.hide();
Resolution : instead of hide() close() is implemented.

3. Issue : closing current and opening new form resulted in both the form getting disposed.
 code used : 
					this.Hide();
					frmOptions formoptions = new frmOptions();
                    formoptions.Show();
                    this.Close();

changed code :
					this.Hide();
                    frmOptions formoptions = new frmOptions();
                    formoptions.ShowDialog();
                    this.Close();

4.Challenge 1 : displaying --select-- in combo box  --done. taking new row and adding values

5. Updating PIN -done.  but it is always returning true even if it does not update data. need to look into this. - use output parameters 
- changes in Output parameter function  is done - Resolved

6. Restrict only 4 number . Set MaxLength property in TextBox

7.Validate dropdownlist and textbox selection upon button click event --done


8. customer registration page - casading drop down values problem .

 View State disabling has fixed the issue. but by further selecting state its value is getting lost.

 Final solution : for last drop down , view state is disabled. For the first drop down clearing the middle drop down and inserting 0th value position has been implemented.




--------------------------Common screen ------------------------------
frmEnterAmount.cs
frmSelectAccount.cs
(need some common coding here
-------------------------Common screen-------------------------------





------------------------------------------------------------
 Balance Enquiry Screen :
 1. Please select your Account Screen --display of account is ignored / not required
 2. Showing Balance Details : Report -- Need to be worked for- Generalized procedure
     Bank Branch Details on the top  
	 Date and Time
	 Card Number
	 Account Number
	 Response Code : Hard coded
	 Table Involved : 
	 Bank Id need to be carried out from option screen. 'balancedetails' (balance and Account number). 'creditcard' for showing Card number
---------------------------------------------------------------------
Cash Withdrawal Screen :
1.Please select your Account Screen
2.Please enter the amount in multiples of 500.
Collect latest time stamp value from the table 'balancedetails' and subtract the value. based on (passing parameter)  bankId,CustomerId and latest timestamp
get the amount and subtract the value
----------------------------------------------------------
Change PIN screen : 

1. Change pin by selecting bank   -- get procedure is written. just need to call after finishing the  screen 'Adding creditcard Details'
2. Going back to Select options screen  --Done
-------------------------------------------------------------
Mini Statement Screen: 
1. Please select your Account Screen 
2. Showing Balance Details : Report -- Need to be worked for- Generalized procedure calling

Bill Payment Screen :
 ---Check if other options are available

 -----------------------------------------------------------------
 Fund Transfer Screen:

 New screen to be added : 

Screens : Please select fund transfer type :  

1. Inter Bank Transfer : All the available bank should be diaplayed  > 
     On selecting bank ask for Account No > Ask for the amount > Verification & Confirmation

2. Intra Bank Transfer : 
 To Personal Account : Saving Account; PPF Account ; FD Account ; RD Account
 To Others Account : Ask for Account No > Ask for amount > Verification and conformation
 ---------------------------------------------------------------------------

 CREATE PROCEDURE GetCardDetails
@customerID INT
AS
BEGIN
SELECT creditID,cdetails,expdate,validity,valid FROM creditcard WHERE customerID=@customerID
END