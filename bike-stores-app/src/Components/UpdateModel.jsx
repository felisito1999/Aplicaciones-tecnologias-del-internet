import React, {Component} from 'react';
import axios from 'axios';
import { data } from 'jquery';

export default class UpdateModel extends Component{
    constructor(props)
    {
        super(props);
        this.state = {
            productId: props.productId,
            productName: "",
            listPrice: 0, 
            modelYear: 0,
            brandId: 1,
            categoryId: 1,
            product: {},
            onClose: props.onClose,

            brands: [],
            categories: []
        };
        axios.get('api/Brand/').then(
            res => {
                const brands = res.data;
                this.setState({brands});
        });
        axios.get('api/Category/').then(
            res => {
            const categories = res.data;
            this.setState({categories});
        });
        axios.get('api/Category/' + this.state.productId).then(
            res => {
                const product = res.data;
                this.setState({product})
                console.log(product.ProductName)
            }
        )
    }

    render(){
        return(
            <div className="modal fade-show" id="updateModal" style={{display: "block"}} role="dialog">
                <div className="modal-dialog modal-dialog-centered modal-lg">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title" id="exampleModalLongTitle">Update a bike</h5>
                            <button type="button" className="close" data-dismiss="modal" aria-label="Close" onClick = {this.state.onClose}>
                            <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div className="modal-body">
                            <form id="addProductForm" name="addProductForm" className="form" onSubmit ={this.insertBikeSubmit} >
                                <div className="form-group">
                                    <label htmlFor="productName">Bike name</label>
                                    <input id="productName" value={this.state.product.ProductName} type="text" minLength="4" maxLength="50" onChange={evt => this.updateProductNameValue(evt)} className="form-control" name="productName"  placeholder="Enter a new bike name"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="listPrice" className="form-label"> Bike list price</label>
                                    <div className="input-group mb-3">
                                        <div className="input-group-prepend">
                                            <span className="input-group-text">$</span>
                                        </div>
                                        <input id="listPrice" name="listPrice" onChange={evt => this.updateProductListPriceValue(evt)} placeholder="0.00" type="number" min="0.00" step="0.01" className="form-control"/>
                                    </div>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="modelYear">Model year</label>
                                    <input type="number" id="modelYear" onChange={evt => this.updateProductModelYearValue(evt)} className="form-control" name="modelYear"
                                    placeholder={this.year}
                                    max={this.year} min="0" step="1"aria-describedby="modelYearHelp" />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="bikeBrand">Bike brand</label>
                                    <select id="brandId" value={this.state.brandId} onChange={evt => this.updateBrandIdValue(evt)} name="brandId" className="custom-select">
                                        {this.state.brands.map(brand => <option key={brand.BrandId} value= {brand.BrandId}>{brand.BrandName}</option>)}
                                    </select>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="bikeCategory">Bike category</label>
                                    <select id="categoryId" value={this.state.categoryId} onChange={evt => this.updateCategoryIdValue(evt)} name="categoryId" className="custom-select">
                                        {this.state.categories.map(category => <option key={category.CategoryId} value= {category.CategoryId}>{category.CategoryName}</option>)}
                                    </select>
                                </div>
                            </form>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-dismiss="modal" onClick={this.state.onClose}>Close</button>
                            <button type="submit" className="btn btn-primary" form="addProductForm" onClick={this.insertBikeSubmit}>Add bike</button>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}