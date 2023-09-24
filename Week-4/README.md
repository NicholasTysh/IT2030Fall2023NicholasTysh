## ERROR 1
```
'widht' is not a known CSS property name.
```

### DESCRIPTION
On the initial build of the project the error `'widht' is not a known CSS property name.` populates the error list. The file that has the error is the `site.css` file in the `wwwroot/css/` directory. 

### FIX
Change `widht` to `width` in the CSS file.


## ERROR 2
```
; expected
```

### DESCRIPTION  
Double clicked the error message which redirected me to the error located on line 16 in the `TipCalculator.cs` file located in the Models folder.

### FIX  
Added a `;` to the ending of line 16.


## ERROR 3
```
HomeController.Index(): not all code paths return a value.
```

### DESCRIPTION
There is no return statement attached to the View() that is being returned.

### FIX
Added a `return` before the `View();` on line 15 of the `HomeController.cs` file in the Controller folder.


## ERROR 4  
```
The name Viewbag does not exist in the current context.
```

### DESCRIPTION
The b in Viewbag is lowercase and should be uppercase.

### FIX
Changed the lowercase `b` to an uppercase `B` on line 14 of the `HomeController.cs` file in the Controller folder.


## ERROR 5
```
AspNetCoreGeneratedDocument.Views\_Home\_Index.<ExecuteAsync>b\_\_14\_1() in Index.cshtml
+ 
<label>@ViewBag.Fifteem.ToString("c2")</label>
```

### DESCRIPTION
This stack trace error indicates that there is an error in the `Views/Home/Index.cshtml` file on line 16. `Fifteem` should be `Fifteen`.

### FIX
Change `Fifteem` to `Fifteen` in the `Views/Home/Index.cshtml` file on line 16.


## ERROR 6
Tip calculation is incorrect. 

### DESCRIPTION
Calculation is dividing the cost by the tip, it should be multiplying the values.

### FIX
Change the division sign to a multiplication sign on line 15 of the `TipCalculator.cs` file located in the Models folder.

