# StockMarketAnalyser

## 3rd partty application 
This project utilise the following technologies : 
Stock MArket data from Qandl 
Data provider for stock market : https://www.quandl.com/

##### Tweets from Twitter 




Make sure to install the following R package inside your R engine : 

library(NLP)
library(tm)
library(TTR)


# Instalation : 

run the update-database to update the DB based on latest migration 

after update the DB create the view mentioned below : 

  create view "View_TweetsSummary" as
  select [Screen_Name], MAX([CreateDate]) as LastUpdate, MAX([Date]) as LastTweetDate , COUNT([Tweets]) as NOofRecords from [stockmarket].[dbo].[Tweet]  group by [Screen_Name]
  
  
  
  create view "View_StockSummary" as
  select [StockIndex], max([Date]) as EndDate, min([Date]) as StartDate from [stockmarket].[dbo].[TimeSeriesIndex] group by [StockIndex]



Twitter API : 
In order to use twitter API you need to Get the Consumer Key, Consumer Secret, Acess token, Access Token Secret for your application you can find them here :
https://developer.twitter.com/en/docs/basics/authentication/guides/access-tokens.html

Qandel API : 
to se stock market data you need to get a quandel API tocken 
you can find it here : 
https://help.quandl.com/article/320-where-can-i-find-my-api-key