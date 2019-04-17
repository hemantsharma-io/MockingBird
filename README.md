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
1. Fiddler installed on machine
2. .Net framework 4.5.2

## Usage ##
[Watch this video](help/MockingBird-Usage.mp4) to know how to convert a request
