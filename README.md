# xaml-advanced

This repo consists of artifacts from edX course DEV206.2x Designing Advanced Applications using XAML.  The online course was designed and conducted by Microsoft and ended on January 20, 2016.  The remainder of this README describes the last homework assignment I completed for the course.

## Overview

[![Overview video](http://img.youtube.com/vi/KHm9wMoYN6Y/0.jpg)](http://www.youtu.be/KHm9wMoYN6Y)

## Homework 4

In this assignment, you will implement the MVVM pattern with your existing application.

## Implementing a Base ViewModel

You will create a base ViewModel class that can be used as a common location for the data repository and INotifyPropertyChanged implementation. The implementation of this base class and the implementation of the factory for the data repository are all provided at the bottom of this unit. Your OrderViewModel and ExpediteViewModel classes will inherit from the base ViewModel class.  The ExpeditePage will use the ExpediteViewModel as it's data context and a similar relationship will exist between the OrderPage and the OrderViewModel.

## Instructions

1. Implement a common ViewModel base class to replace the DataManager class
  - The implemenation for this base class is provided below
2. Update the name of the OrderDataManager class to OrderViewModel
3. Update the name of the ExpediteDataManager class to ExpediteViewModel
4. Create a new Model project
  - Model classes (data representations) should exist only here
  - The main project should reference this project
5. Create a new ViewModel project
  - ViewModel classes (behavior and logic) should exist only here
  - This project should reference the Model project
  - The main project should reference this project
6. Update the list of Currently Selected Menu Items (OrderViewModel) to be of type ObservableCollection<MenuItem> instead of List<MenuItem>
7. Add Command for adding Menu Items to the Currently Selected Menu Items list
8. Add Command for submitting the Currently Selected Menu Items as a new Order to the data repository
9. Validate that the project works as described in the Overview video
