﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: E2E_CRSApplication_Licence_privatecorp
    As a logged in business user
    I want to submit a CRS Application for a private corporation
    And submit licence changes for the approved application

Scenario: Start Application
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee
    And I click on the licence download link
    And I plan the store opening
    And I request a store relocation
    And I request a valid store name or branding change
    And I request a structural change
    And I review the federal reports
    And I show the store as open on the map
    And I request a transfer of ownership
    And I request a personnel name change
    And I change a personnel email address
    Then the requested applications are visible on the dashboard
*/

namespace bdd_tests
{
    [FeatureFile("./E2E_CRSApplication_Licence_privatecorp.feature")]
    public sealed class E2ECRSApplicationLicencePrivateCorp : TestBase
    {
        public void CheckFeatureFlagsCannabis()
        {
            // navigate to the feature flags page
            driver.Navigate().GoToUrl($"{baseUri}api/features");

            // confirm that the CRS-Renewal flag is enabled during this test
            Assert.True(driver.FindElement(By.XPath("//body[contains(.,'CRS-Renewal')]")).Displayed);
        }

        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CheckFeatureFlagsCannabis();

            CarlaLoginNoCheck();
        }

        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Start Application button for a Cannabis Retail Store")]
        public void I_start_application()
        {
            /* 
            Page Title: Welcome to Cannabis Licensing
            */

            // click on the Start Application button
            NgWebElement startApp_button = ngDriver.FindElement(By.XPath("//button[text()='START APPLICATION']"));
            startApp_button.Click();
        }

        [And(@"I complete the eligibility disclosure")]
        public void complete_eligibility_disclosure()
        {
            CRSEligibilityDisclosure();
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            ReviewAccountProfile();
        }

        [And(@"I review the organization structure")]
        public void I_continue_to_organization_review()
        {
            ReviewOrgStructure();
        }

        [And(@"I submit the organization structure")]
        public void submit_org_structure()
        {
            SubmitOrgInfoButton();
        }

        [And(@"I complete the Cannabis Retail Store application")]
        public void I_complete_the_application()
        {
            CRSApplication();
        }

        [And(@"I click on the Pay for Application button")]
        public void click_on_pay()
        {
            NgWebElement pay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'Pay for Application')]"));
            pay_button.Click();
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            MakePayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            CRSReturnToDashboard();
        }

        [And(@"the application is approved")]
        public void application_is_approved()
        {
            // navigate to api/applications/<Application ID>/process
            driver.Navigate().GoToUrl($"{baseUri}api/applications/{application_ID}/process");

            // wait for the autoamted approval process to run
            System.Threading.Thread.Sleep(20000);

            // navigate back to dashboard
            ngDriver.Navigate().GoToUrl($"{baseUri}/dashboard");
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [And(@"I click on the Licences tab for a (.*)")]
        public void click_on_licences_tab(string applicationType)
        {
            /* 
            Page Title: Welcome to Liquor and Cannabis Licensing
            */

            applicationTypeShared = applicationType;

            string licencesLink = "Licences";

            // click on the Licences link
            NgWebElement uiLicences = ngDriver.FindElement(By.LinkText(licencesLink));
            uiLicences.Click();
        }

        [And(@"I pay the licensing fee")]
        public void pay_licence_fee()
        {
            PayCRSLicenceFee();
        }

        [And(@"I click on the licence download link")]
        public void click_licence_download_link()
        {
            DownloadLicence();
        }

        [And(@"I plan the store opening")]
        public void plan_store_opening()
        {
            PlanStoreOpening();
        }

        [And(@"I request a store relocation")]
        public void request_store_relocation()
        {
            RequestRelocation();
        }

        [And(@"I request a valid store name or branding change")]
        public void request_name_branding_change()
        {
            StoreNameBrandingChange();
        }

        [And(@"I request a structural change")]
        public void request_structural_change()
        {
            RequestStructuralChange();
        }

        [And(@"I review the federal reports")]
        public void review_federal_reports()
        {
            ReviewFederalReports();
        }

        [And(@"I request a transfer of ownership")]
        public void request_ownership_transfer()
        {
            RequestTransferOwnership();
        }

        [And(@"I show the store as open on the map")]
        public void show_store_open_on_map()
        {
            ShowStoreOpen();
        }

        [And(@"I request a personnel name change")]
        public void request_personnel_name_change()
        {
            RequestPersonnelNameChange();
        }

        [And(@"I change a personnel email address")]
        public void request_personnel_email_change()
        {
            RequestPersonnelEmailChange();
        }

        [Then(@"the requested applications are visible on the dashboard")]
        public void licences_tab_updated()
        {
            RequestedApplicationsOnDashboard();
        }
    }
}