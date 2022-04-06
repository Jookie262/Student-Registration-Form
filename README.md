# Student Registration Form
A C# activity in the subject Integrative Programming that aims to create a student registration form in winform. I made the UI more interesting than the original. The program uses **.Net Framework version 4.6.1**. 

## Walkthrough of Codes
Here some useful codes that I used when creating the activity 

### Populating the Combo Box
This method populates or insert data inside the combo box for the Day. "day_combo_box" is the name of my combo box. Then, in the FormLoad Event or Constructor, call this method.
```
public void populateDay()
{
    for (int x = 1; x <= 31; x++) {
        day_combo_box.Items.Add(x);
    }
}
```

### Setting up the default value for Combo Box
Insert a text "-Day-" with the index of 0 to put it in the first list then select the index 0 to finally  set your default value in Combo Box. 
```
day_combo_box.Items.Insert(0, "-Day-");
day_combo_box.SelectedIndex = 0;
```

## Screen Shot 📷
<p float="center">
	<img src = "screenshot/1.png" width="48%">
	<img src = "screenshot/2.png" width="48%">
</p>

## Contribution 🔥

If you wish to help improve this project, fork this repo and submit your own pull request. If you discover a problem with this project, please report it to the issue page. Thank you very much 😊.

## Thank you 😃

If you like this project just click ⭐ and share it with others.