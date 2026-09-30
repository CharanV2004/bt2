const fs = require("fs");

const file1 = "MCA.txt";
const data = "Student :: Charan, Roll No :: 25MCA18, Branch :: MCA";

fs.writeFile(file1, data, function(err) {
    if (err) {
        console.log(err);
    } else {
        console.log("File created successfully");

        fs.readFile(file1, "utf8", function(err, data) {
            if (err) {
                console.log(err);
            } else {
                console.log("File content:", data);
            }
        });
    }
});

console.log(data);