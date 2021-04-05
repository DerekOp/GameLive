from django.urls import path
from . import views
from .products import products

urlpatterns = [
    path('' , views.getRoutes, name ="routes"),
    path('products/' , views.getGameDetails, name='products'),
    path('products/<str:primarykey>/' , views.getGameDetail, name='product'),
]
