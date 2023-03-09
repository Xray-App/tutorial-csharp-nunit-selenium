#!/bin/bash
FILE="TestResults/nunit_webdriver_tests.xml"
PROJECT=CALC
TESTPLAN=""
BROWSER=""
token=$(curl -H "Content-Type: application/json" -X POST --data @"cloud_auth.json" https://xray.cloud.getxray.app/api/v2/authenticate| tr -d '"')
curl -H "Content-Type: application/xml" -X POST -H "Authorization: Bearer $token"  --data @"$FILE" "https://xray.cloud.getxray.app/api/v2/import/execution/nunit?projectKey=$PROJECT&testPlanKey=$TESTPLAN&testEnvironments=$BROWSER"
