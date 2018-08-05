# MockingBird #
There are lots of reason you might need to degug a http request(s), be it try to recreate a issue and narrow-down the problem in your favorite language or compare contents between different request(s). MockingBird is a Fiddler extension to transform a request to any format you want e.g. you can generate Java, C#.net or any other language code from a request you want to troubleshoot issues. It is not limited to a programming language and you can transform the data to any format you want e.g. CSV as long as you know how to create template. Internally it uses Nustache which supports logic less Mustache templates.

## Features ##
### Convert request to any format you want ###
As soon as you have a template it's just a matter of dragging and dropping selected request(s) to the code area and Voila!! the code is ready.

### Can convert multiple http request ###
Select any number of request you want and just drop inside _Generate Tab_ tab.

### Support multiple templates ###
Create as many templates as you need. Just place them inside _<Fiddler's script path>/MockingBirdTemplates/\<TemplateName>.tpl_ and restart Fiddler the template will be avilable in ___Template___ tab. Simply select it and drag and drop request in _Generate Code_ tab.

### Edit templates at runtime ###
You can make changes to selected template in _Template_ tab and click on Save button to save it. All the request would be trasformed as per the updated changes.

## How to install ##
1. Download [MockingBird.zip](MockingBird.zip)
2. Extract it to Fiddler's script folder. You can find the folder path from Fiddler > Tools > Options > Extesions (tab)
3. Restart Fiddler

## System requirement ##
1. Fiddler installed on machine
2. .Net framework 4.5.2