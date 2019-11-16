# ImageMatcher
Computing how similar are 2 photos

### Usage
```
var reader = new ImageReader();
var strategy = new StrictMatcherStrategy();            
var runner = new ImageMatcherRunner(reader, strategy);
var result = runner.RunMatcher("TestData/TestImage.png", "TestData/TestImage.png");
```
Result is number from 0 to 100. 0 means photots are exacly the same (based on strategy used). 100 is black image vs. white image - 100% dismatch. So far there is only one strategy - but so far it was sufficient to get reasonable results.
