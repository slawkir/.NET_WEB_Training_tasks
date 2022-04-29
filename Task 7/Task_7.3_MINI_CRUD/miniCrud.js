class Service {
  constructor() {
    this.list = [];
  }
  add(newItem) {
    this.list.push(newItem);
  }
  getById(id){
    return this.list[id];
  }
  getAll(){
    let test = [this.list];
    test.forEach(item => {
        return item;
    });
    return(this.list);
  }
  deleteById(id){
    this.list.splice(id, 1);
  }
  updateById(id, content){
    this.list[id] = this.list[id] + content;
  }
}

var storage = new Service();
console.log(storage.add('hello'));
console.log(storage.add(", world!"));
console.log(storage);


