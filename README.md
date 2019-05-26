![Mocking Bird](MockingBird.png "Mocking Bird")
# MockingBird #
There are lots of reason you might need to debug a http request(s), be it try to recreate a issue and narrow-down the problem in your favorite language editor or compare contents between different request(s) etc. MockingBird is a Fiddler extension to transform a request to any format you want e.g. you can generate Java, C#.net or any other language code from selected requests you want to troubleshoot issues for and use the output code in your favourite IDE. It's not limited to just code and can be used to create any format as long as you can create a Mustache template for it e.g. you can create a csv file with selected HTTP request to perform a functional or load test in SOAP UI or JMeter.

## Features ##
### Convert HTTP requests to any format you want ###
As soon as you have a template it's just a matter of dragging and dropping selected request(s) to the code area and Voila!! the code is ready.

### Can convert multiple http request ###
Select multiple requests and just drop inside _Generate Tab_ tab.

### Support multiple templates ###
Create as many templates as you need. Just place them inside _<Fiddler's script path>/MockingBirdTemplates/\<TemplateName>.tpl_ and restart Fiddler the template will be avilable in ___Template___ tab. Simply select it and drag and drop HTTP request in _Generate Code_ tab.

### Edit templates at runtime ###
You can make changes to selected template in _Template_ tab and click on Save button to save it. All the request would be trasformed as per the updated changes.

## How to install ##
1. Download [MockingBird.zip](MockingBird.zip)
2. Extract it to Fiddler's script folder. You can find the folder path from Fiddler > Tools > Options > Extesions (tab)
3. Start/Restart Fiddler

## System requirement ##
1. Fiddler v5.0.20182.28034 or higher


## How To(s)? ##
### **Convert a HTTP request to Java code and debug it in IntelliJ Idea in Fiddler** ###
   > [Watch this video](https://youtu.be/SujiYylkB7s)  


### **Convert a Fiddler session to JMX (i.e. JMeter) for perf testing** ###

1. Select _'JMeter Load Test'_ template from drop down in _Template_ tab

   > I created a simple HTTP sampler JMeter project and having a loop count of 100 and saved the _.jmx_ file as _.tpl_ after adding mustache tags
   > 
   >![Img](help/Jmeter/Simple%20GET%20HTTP%20Load%20Test/JmeterBlankProject.png)

2. Switch to _Generate Code_ tab
3. Drag & Drop HTTP Request to code area

   ![](help/Jmeter/Simple%20GET%20HTTP%20Load%20Test/GenerateCode.png)

4. Click _Save as file_ button. Enter _JMeter Load Test.jmx_ as file name and click _Save_ button to save the file.

   ![](help/Jmeter/Simple%20GET%20HTTP%20Load%20Test/SaveJmx.png)

5. Open JMeter and open _JMeter Load Test.jmx_ file
6. Click ![_start_](help/Jmeter/Simple%20GET%20HTTP%20Load%20Test/StartButton.png) button in JMeter window's toolbar
7. Click on _Aggregate Report_ and it will display you the aggregate run results like below.

   >![Aggregate Report](help/Jmeter/Simple%20GET%20HTTP%20Load%20Test/AggregateReport.png)
