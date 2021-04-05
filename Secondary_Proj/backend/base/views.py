from django.shortcuts import render
from django.http import JsonResponse
from rest_framework.response import Response
from rest_framework.decorators import api_view
from .products import products
# Create your views here.

@api_view (['GET'])
def getRoutes(request): # Home list will return a set of available pages to plug into. Copy paste /../ at end of port to run. Some take arguments though.
    routes = ['/api/products/',
              '/api/products/create',
              '/api/products/upload',
              '/api/products/<id>/reviews/',
              '/api/products/top/']
    return Response(routes) 
@api_view(['GET'])
def getGameDetails(request):
    return Response(products)

@api_view(['GET'])
def getGameDetail(request,primarykey): #This is taking in the products ID as the primary key then itterarting through products until it finds the right one.
    for x in products:
        if x['prod_Id'] == primarykey:
            product = x
            break
    return Response(product) # This is calling the products visit products.py for general understanding of data.