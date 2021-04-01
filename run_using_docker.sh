#!/bin/bash

docker build . -t nunit_webdriver_tests

#docker run --rm -t nunit_webdriver_tests
#docker run --rm -v $(pwd)/bin/Debug/net5.0/TestResults:/source/bin/Debug/net5.0/TestResults -t nunit_webdriver_tests
docker run --rm -v $(pwd)/TestResults:/source/bin/Debug/net5.0/TestResults -t nunit_webdriver_tests
