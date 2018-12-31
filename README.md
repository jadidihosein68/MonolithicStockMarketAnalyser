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
