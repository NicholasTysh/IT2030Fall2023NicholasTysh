# Week 11 Lab Summary

## Overview

Add data validation to the ContactModel and ProductModel classes. Create an Events page to display upcoming events.

## Instructions

1. Add data validation to the ContactModel fields:

   - FirstName: 30 chars max, no special chars/numbers
   - LastName: 30 chars max, no special chars/numbers  
   - Phone: 10 digits, numbers only
   - Email: valid email address

2. Add data validation to the ProductModel fields: 

   - ProductName: required
   - ProductDescription: required
   - ProductImage: required
   - ProductPrice: currency data type

3. Add Events link to navigation menu.

4. Create Events view page:

   - Title, heading
   - 4 events with description, title, age group, date, time, location, registration info
   - Style events using Bootstrap cards or other styling 

5. Add action method in HomeController to display Events page
