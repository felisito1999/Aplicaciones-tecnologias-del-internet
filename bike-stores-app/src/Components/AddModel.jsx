import React, {Component} from 'react'; 
import axios from 'axios';
import * as ReactBootStrap from 'react-bootstrap';

export default class AddModal extends Component{
    _isMounted = false; 
    constructor(props)
    {
        super(props);
        this.state = {
            onClose: props.onClose,
            brands: [], 
            categories: [], 
            productName: '',
            modelYear: 0, 
            listPrice: 0.00,
            brandId: 1,
            categoryId: 1,
            products: [props.products],
            year: new Date().getFullYear()
        }
    }

    componentDidMount(){
        this._isMounted = true; 
        axios.get('/api/Brand/').then( res => {
            const brands = res.data;
            this.setState({brands});
        })
        axios.get('/api/Category/').then( res => {
            const categories = res.data;
            this.setState({categories}); 
        })
    }
    componentWillUnmount(){
        this._isMounted = false; 
    }
    insertBikeSubmit = (e) =>{
        
        e.preventDefault();

        if(this.state.productName.length > 4 && this.state.modelYear > 0 && this.state.listPrice > 0 ){
            axios.post('api/Product/', {
                ProductId: null, 
                ProductName: this.state.productName,
                ModelYear: this.state.modelYear,
                ListPrice: this.state.listPrice,
                BrandId: this.state.brandId,
                BrandName: null,
                CategoryId: this.state.categoryId,
                CategoryName: null
             }).then(res => {
                 if(this._isMounted)
                 {
                     this.setState({products: [...this.props.products, res.data]})
                 }
             });
             alert("The product has been saved successfully!");
             this.state.onClose();
        }
        else {
            alert("Some fields have not been filled correctly, no action has been done!")
        }
    };
    updateProductNameValue(evt) {
        this.setState({
          productName: evt.target.value
        });
      };
    updateProductModelYearValue(evt){
        this.setState({
            modelYear: evt.target.value
        });
    };
    updateProductListPriceValue(evt){
        this.setState({
            listPrice: evt.target.value
        });
    };
    updateBrandIdValue(evt){
        this.setState({
            brandId: evt.target.value
        });
    };

    updateCategoryIdValue(evt){
        this.setState({
            categoryId: evt.target.value
        })
    }

    year =  new Date().getFullYear();

    render(){
        return(
            <div className="modal fade-show" id="updateModal" style={{display: "block"}} role="dialog">
                <div className="modal-dialog modal-dialog-centered modal-lg">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title" id="exampleModalLongTitle">Add a beautiful bike</h5>
                            <button type="button" className="close" data-dismiss="modal" aria-label="Close" onClick = {this.state.onClose}>
                            <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div className="modal-body">
                            <form id="addProductForm" name="addProductForm" className="form" onSubmit ={this.insertBikeSubmit} >
                                <div className="form-group">
                                    <label htmlFor="productName">Bike name</label>
                                    <input id="productName" type="text" minLength="4" maxLength="50" onChange={evt => this.updateProductNameValue(evt)} className="form-control" name="productName"  placeholder="Enter a new bike name"/>
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

// export default function UpdateModal( {brands, categories, onClose, onAccept}){   

//     const insertBikeSubmit = (e) =>{
        
//         e.preventDefault();

//         const productName = e.target.elements["productName"].value;
//         // const modelYear = e.target.elements["modelYear"].value; 
//         // const listPrice = e.target.elements["listPrice"].value; 

//         // const selectBrand = e.target.elements["brandId"]
//         // const selectedBrand = selectBrand.options[selectBrand.selectedIndex].value; 

//         // const selectCategory = e.target.elements["categoryId"]
//         // const selectedCategory = selectCategory.options[selectCategory.selectedIndex].value; 
        
//         // const bikeName = document.getElementById("productName").value;
//         // const bikeListPrice = document.getElementById("listPrice").value;
//         // const bikeModelYear = document.getElementById("modelYear").value;
//         // const bikeBrandId = selectedBrand;
//         // const bikeCategoryId = selectedCategory;
        
//         onAccept({
//             ProductId : null,
//             ProductName: productName
//             // ModelYear: modelYear,
//             // ListPrice: listPrice,
//             // BrandId: selectedBrand,
//             // BrandName: null,
//             // CategoryId: selectedCategory,
//             // CategoryName: null
//         })
//     }

//     let year =  new Date().getFullYear();
//     return(
//         <div className="modal fade-show" id="updateModal" style={{display: "block"}} role="dialog">
//             <div className="modal-dialog modal-dialog-centered modal-lg">
//                 <div className="modal-content">
//                     <div className="modal-header">
//                         <h5 className="modal-title" id="exampleModalLongTitle">Add a beautiful bike</h5>
//                         <button type="button" className="close" data-dismiss="modal" aria-label="Close" onClick = {onClose}>
//                         <span aria-hidden="true">&times;</span>
//                         </button>
//                     </div>
//                     <div className="modal-body">
//                         <form id="addProductForm" name="addProductForm" className="form" onSubmit ={insertBikeSubmit} >
//                             <div className="form-group">
//                                 <label htmlFor="productName">Bike name</label>
//                                 <input id="productName" className="form-control" name="productName"  placeholder="Enter a new bike name"/>
//                             </div>
//                             <div className="form-group">
//                                 <label htmlFor="listPrice" className="form-label"> Bike list price</label>
//                                 <div className="input-group mb-3">
//                                     <div className="input-group-prepend">
//                                         <span className="input-group-text">$</span>
//                                     </div>
//                                     <input id="listPrice" name="listPrice" placeholder="0.00" type="number" min="0.00" step="0.01" className="form-control"/>
//                                 </div>
//                             </div>
//                             <div className="form-group">
//                                 <label htmlFor="modelYear">Model year</label>
//                                 <input type="number" id="modelYear" className="form-control" name="modelYear"
//                                 placeholder={year}
//                                  max={year} min="0" step="1"aria-describedby="modelYearHelp" />
//                             </div>
//                             <div className="form-group">
//                                 <label htmlFor="bikeBrand">Bike brand</label>
//                                 <select id="brandId" name="brandId" className="custom-select">
//                                     {brands.map(brand => <option key={brand.BrandId} value= {brand.BrandId}>{brand.BrandName}</option>)}
//                                 </select>
//                             </div>
//                             <div className="form-group">
//                                 <label htmlFor="bikeCategory">Bike category</label>
//                                 <select id="categoryId" name="categoryId" className="custom-select">
//                                     {categories.map(category => <option key={category.CategoryId} value= {category.CategoryId}>{category.CategoryName}</option>)}
//                                 </select>
//                             </div>
//                         </form>
//                     </div>
//                     <div className="modal-footer">
//                         <button type="button" className="btn btn-secondary" data-dismiss="modal" onClick={onClose}>Close</button>
//                         <button type="submit" className="btn btn-primary" form="addProductForm" onClick={insertBikeSubmit}>Add bike</button>
//                     </div>
//                 </div>
//             </div>
//         </div>
//     )
// }