from django.db import models

# Create your models here.
class Organization(models.Model):
    Name=models.CharField(max_length=100)

class Organization_BusinessType(models.Model):
    Organization=models.ForeignKey(Organization)
    BusinessType=models.ForeignKey(BusinessType)

class BusinessType(models.Model):
    Name=models.CharField(max_length=200)