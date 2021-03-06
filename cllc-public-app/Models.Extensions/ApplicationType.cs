﻿using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.ViewModels;
using System.Collections.Generic;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class ApplicationTypeExtensions
    {

        public static ApplicationType ToViewModel(this MicrosoftDynamicsCRMadoxioApplicationtype applicationType)
        {
            ApplicationType result = null;
            if (applicationType != null)
            {
                result = new ApplicationType()
                {
                    Id = applicationType.AdoxioApplicationtypeid,

                    ActionText = applicationType.AdoxioActiontext,
                    Name = applicationType.AdoxioName,
                    Title = applicationType.AdoxioTitletext,
                    ShowAssociatesFormUpload = applicationType.AdoxioIsshowassociatesformupload,
                    ShowCurrentProperty = applicationType.AdoxioIsshowcurrentproperty,
                    ShowDeclarations = applicationType.AdoxioIsshowdeclarations,
                    ShowFinancialIntegrityFormUpload = applicationType.AdoxioIsshowfinancialintegrityformupload,
                    ShowHoursOfSale = applicationType.AdoxioIsshowhoursofsale,
                    ShowPropertyDetails = applicationType.AdoxioIsshowpropertydetails,
                    ShowSupportingDocuments = applicationType.AdoxioIsshowsupportingdocuments,
                    EstablishmetNameIsReadOnly = applicationType.AdoxioIslockestablishmentname,
                    StoreContactInfo = (FormControlState?)applicationType.AdoxioStorecontactinfo,
                    EstablishmentName = (FormControlState?)applicationType.AdoxioEstablishmentname,
                    newEstablishmentAddress = (FormControlState?)applicationType.AdoxioNewestablishmentaddress,
                    CurrentEstablishmentAddress = (FormControlState?)applicationType.AdoxioCurrentestablishmentaddress,
                    Signage = (FormControlState?)applicationType.AdoxioSignage,
                    ValidInterest = (FormControlState?)applicationType.AdoxioValidinterest,
                    FloorPlan = (FormControlState?)applicationType.AdoxioFloorplan,
                    SitePlan = (FormControlState?)applicationType.AdoxioSiteplan,
                    ShowDescription1 = applicationType.AdoxioShowdescription1,
                };

                if (applicationType.AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType != null)
                {
                    result.contentTypes = new List<ApplicationTypeContent>();
                    foreach (var content in applicationType.AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType)
                    {
                        result.contentTypes.Add(content.ToViewModel());
                    }
                }
                /*
                if (dynamicsApplicationType.AdoxioLicenceTypeId != null)
                {
                    result.LicenseType = dynamicsApplicationType.AdoxioLicenceTypeId.ToViewModel();
                }
                */
            }


            return result;
        }
    }
}
