# **QuickApp** - ASPNET Core 3.1 / Angular 9 project template
[![MIT license](https://cdn.rawgit.com/emonney/tempa/7e9d69ad/MITLicense.png)](https://github.com/emonney/QuickApp/blob/master/LICENSE)
[![VSIX Downloads](https://img.shields.io/visual-studio-marketplace/d/adentum.QuickApp-ASPNETCoreAngularXProjectTemplate)](https://marketplace.visualstudio.com/items?itemName=adentum.QuickApp-ASPNETCoreAngularXProjectTemplate)
[![Twitter Follow](https://img.shields.io/twitter/follow/kommand?style=social)](https://twitter.com/kommand)

A startup **Angular 9 / ASP.NET Core 3.1** (cross-platform ) **project template** with an end-to-end login, user and role management implementation.
As well as other common functionalities for **Quick Application Development**.

[FOLLOW ME](https://twitter.com/kommand) on twitter for important updates

###### NOTE: This project has started from [QuickApp template](https://github.com/emonney/QuickApp). 

###### It is also using [Finbuckle](https://github.com/Finbuckle/Finbuckle.MultiTenant/) library. 


I want to implement multitenancy for a rest api with tenant based in claims of JWT token. I am using IdentityServer4 and Finbuckle.Multitenacy

## Problem I am facing

Identifying the tenants based on JWT claims. It seems that at the time of writing Finbuckle supports only cookie based claims.

## How to setup the project

The current project after running creates the database QuickAppMDb. To create other databases, QuickAppM2d, QuickAppM3d or QuickAppM1 just for testing purposes I rerun the project by changing database name in DefaultConnection in appsettings.json file. (I run 3 times to create 3 more databases).

Default username and password are: admin, tempP@ss1234.
It's good to make some changes at DAL\DatabaseInitializer.cs before creating new databases to make them different from each other... like changing the cust_1 Name each time you create a tenant database.

###### NOTE: I am using SQL Server databases
