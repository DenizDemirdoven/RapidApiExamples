# ASP.NET CORE 7.0

### Table of Contents

- [About Project](#about-project)
- [First Example](#first-example-imdb)
- [Second Example](#second-example-booking)
- [Third Example](#third-example-searchlocationid)
- [Fourth Example](#fourth-example-bookingbycity)
- [3rd Party Libraries](#3rd-party-libraries)
- [Credits](#credits)

### About Project

- This is an Asp.Net Core Web App (MVC) project. Two APIs were selected from RapidApi as examples. 
- The value of "X-RapidAPI-Key" in the controllers was changed because of security issue, so while using the code snippet api key is required!
- The IMDb Top 100 Movies API contains the data of the 100 best movies ever made in a very easy-to-use and organized format.
- booking.com | Find all hotels, view prices, photos of the hotels, reviews, and much more. 

### First Example [Imdb]

- In ImdbController code snippet can be found for request and deserialization.
- There is a view model as ApiMovieViewModel which was customized.
- Pagination code snippet also can be found in the view. 

### Second Example [Booking]

- In BookingController code snippet can be found for request and deserialization.
- In RequestUri some parameters were specified. Hotel list returns according to these parameters.
- There is a view model as BookingApiViewModel which was customized.
- Result list can be seen in the view.

### Third Example [SearchLocationID]

- In SearchLocationID code snippet can be found for request and deserialization.
- The parameter as "cityName" comes from view.
- There is a view model as BookingApiLocationSearchViewModel which was customized.
- Result list can be seen in the view.

### Fourth Example [BookingByCity]
- In BookingByCity code snippet can be found for request and deserialization.
- The parameter as "cityID" comes from view. 
- There is a view model as BookingApiViewModel which was customized.
- Result list can be seen in the view.

### 3rd Party Libraries

The following libraries are used in the application:

- Newtonsoft.Json : Json.NET is a popular high-performance JSON framework for .NET

### Credits

Deniz Demirdöven

- [Github](https://github.com/DenizDemirdoven)
- [LinkedIn](https://www.linkedin.com/in/denizdemirdoven)
- [Email](mailto:denizdemirdoven@gmail.com)
- [Web](https://www.denizdemirdoven.com/)