import React, { Component } from 'react';
import './App.css';
import * as ReactBootStrap from 'react-bootstrap';
import logo from "./logo.svg"
import axios from 'axios';
import AddModal from './Components/AddModel';
import UpdateModel from './Components/UpdateModel'

export default class App extends Component{


  componentDidMount(){
    axios.get('/api/Product/').then( res => {
      const products = res.data;
      this.setState({products: res.data});
    })

    axios.get('api/Brand').then( res =>{
      const brands = res.data;
      this.setState({brands})
    })
    axios.get('api/Category').then(
      res => {
        const categories = res.data;
        this.setState({categories})
      }
    )
  }

  state = {
    products: [],
    brands: [],
    addProductIsOpen: false,
    updateProductIsOpen: false
  }

  productId = 0;

  deleteHandler(evt, id){
    evt.preventDefault();
    this.deleteProduct(id)
  }
  deleteProduct(id)
  {
    axios.delete('api/Product/' + id).then(

    );

    axios.get('/api/Product/').then( res => {
      this.setState({products : res.data});
    })
  }

  openAddProductForm = () => {
    this.setState( {addProductIsOpen: true} )
  }
  closeAddProductForm = () => {
    this.setState({addProductIsOpen: false})
    axios.get('/api/Product/').then( res => {
      this.setState({products : res.data});
    })
  }
  openUpdateProductForm = (evt, id) => {
    evt.preventDefault();
    this.productId = id;
    this.setState({updateProductIsOpen: true})
  }
  closeUpdateProductForm = () => {
    this.setState({updateProductIsOpen: false})
  }
  render(){

    const {addProductIsOpen} = this.state;
    return(
        <div className="bg-secondary">
          <div className="bg-secondary">
            <div className="bg-secondary">
              <ReactBootStrap.Navbar bg="dark" variant="dark">
                <ReactBootStrap.Navbar.Brand href="#home">
                  <img
                    alt=""
                    src={logo}
                    width="30"
                    height="30"
                    className="d-inline-block align-top"
                  />{' '}
                  React Bootstrap
                </ReactBootStrap.Navbar.Brand>
              </ReactBootStrap.Navbar>
            </div>
          </div>
          <hr/>
          <div className="container">
            <button type="button" className="btn btn-light btn-block btn-lg pd-4" data-toggle="modal" data-target = "#up" onClick = {this.openAddProductForm}>
                Add product
              </button>
              { addProductIsOpen ? <AddModal products = {this.state.products} onClose = {this.closeAddProductForm}/> : null}

              {this.state.updateProductIsOpen ? <UpdateModel productId = {this.productId}  onClose = {this.closeUpdateProductForm}/> : null}

              {/* { addProductIsOpen ? <UpdateModal brands = {this.state.brands} categories = {this.state.categories} onClose = {this.closeAddProductForm} onAccept = {(data) =>{
                console.log(data);
              }}/> : null} */}
              <table id="products-table" className="table table-responsive-md table-striped table-dark">
                <thead className="thead-dark">
                  <tr>
                    <th>
                      Product name
                    </th>
                    <th>
                      List price
                    </th>
                    <th>
                      Model year 
                    </th>
                    <th>
                      Brand name 
                    </th>
                    <th>
                      Category name
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {this.state.products.map(product => 
                  <tr key={product.ProductId}>
                      <td>
                        {product.ProductName}
                      </td>
                      <td>
                        {product.ListPrice}
                      </td>
                      <td>
                      {product.ModelYear}
                      </td>
                      <td>
                        {product.BrandName}
                      </td>
                      <td>
                        {product.CategoryName}
                      </td>
                      <td>
                        <button type="button" className="btn btn-light btn-block" data-toggle="modal" data-target = "#up" onClick ={evt => this.openUpdateProductForm(evt, product.ProductId)}>
                        Update
                        </button>
                        <button className="btn btn-danger btn-block" onClick = {evt => {this.deleteHandler(evt, product.ProductId)}}>Delete</button>
                      </td>
                  </tr>)}
                </tbody>
              </table>
          </div>
        </div>
    );
  }
}

// export default class PersonList extends React.Component {
//   state = {
//     products: []
//   }

//   componentDidMount() {
//     axios.get(`/api/Product/`)
//       .then(res => {
//         const products = res.data;
//         this.setState({ products });
//       })
//     // Axios({
//     //   method: 'get',
//     //   headers: {},
//     //   url: `http://localhost:51738/api/Product/`,
//     // }).then(res => {
//     //   console.log(res.data);
//     // })
//   }

//   render() {
//     return (
//       <ul>
//         { this.state.products.map(product => <li>{product.ProductName}</li>)}
//       </ul>

//     )
//   }
// };


