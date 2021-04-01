# Tutorial with NUnit tests using Selenium Webdriver

[![build workflow](https://github.com/Xray-App/tutorial-csharp-nunit-selenium/actions/workflows/main.yml/badge.svg)](https://github.com/Xray-App/tutorial-csharp-nunit-selenium/actions/workflows/main.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FXray-App%2Ftutorial-csharp-nunit-selenium.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2FXray-App%2Ftutorial-csharp-nunit-selenium?ref=badge_shield)
[![license](https://img.shields.io/badge/License-BSD%203--Clause-green.svg)](https://opensource.org/licenses/BSD-3-Clause)
[![Gitter chat](https://badges.gitter.im/gitterHQ/gitter.png)](https://gitter.im/xray/community)

## Overview

Code that supports the tutorial [Testing web applications using Nunit](https://docs.getxray.app/pages/viewpage.action?pageId=32806649) showcasing the integration between [Xray Test Management](https://www.getxray.app/) on Jira and NUnit.

The test automation code implements a basic [Selenium Webdriver test](./WebdriverTest.cs).

## Prerequisites

In order to run this tutorial, you need to have .NET 5.
Dependencies can be installed using:

```bash
dotnet restore
```

## Running

Tests can be run using locally `dotnet` tool.

```bash
dotnet test -s nunit.runsettings
```

Tests can also run inside a Docker container; local directory should be mounted so that NUnit XML results are stored locally.

```bash
docker build . -t nunit_webdriver_tests
docker run --rm -v $(pwd)/TestResults:/source/bin/Debug/net5.0/TestResults -t nunit_webdriver_tests
```


## Submitting results to Jira

Results can be submitted to Jira so that they can be shared with the team and their impacts be easily analysed.
This can be achieved using [Xray Test Management](https://www.getxray.app/) as shown in further detail in this [tutorial](https://docs.getxray.app/pages/viewpage.action?pageId=32806649).

## Contact

Any questions related with this code, please raise issues in this GitHub project. Feel free to contribute and submit PR's.
For Xray specific questions, please contact [Xray's support team](https://jira.xpand-it.com/servicedesk/customer/portal/2).

## References

- [NUnit](https://nunit.org)
- [How Xray processes NUnit XML reports](https://docs.getxray.app/display/XRAYCLOUD/Taking+advantage+of+NUnit+XML+reports)


## LICENSE

[BSD 3-Clause](LICENSE)
