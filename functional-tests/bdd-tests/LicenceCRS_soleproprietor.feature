﻿Feature: LicenceCRS_soleproprietor.feature
    As a logged in business user
    I want to pay the Cannabis Retail Store Licence Fee
    And complete the available application types

Scenario: Pay CRS Licence Fee and Complete Applications
    # Given the CRS application has been approved
    # And I am logged in to the dashboard as a sole proprietorship
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Licences tab
    And I pay the licensing fee
    And I click on the licence download link
    And I plan the store opening
    And I request a store relocation
    And I request a valid store name or branding change
    And I request a structural change
    And I review the federal reports
    And I show the store as open on the map
    And I request a transfer of ownership
    Then the requested applications are visible on the dashboard