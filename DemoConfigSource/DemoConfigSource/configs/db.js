import mongoose from 'mongoose';
export const connect = () => {
    mongoose.connect('mongodb://localhost:27017/Stores', {
        useNewUrlParser: true
    }, (err) => {
        if (!err) {
            console.log("MongoDB connect successfull.");
        } else {
            console.log("Error in database connection: " + JSON.stringify(err, undefined, 2));
        }
    });
}