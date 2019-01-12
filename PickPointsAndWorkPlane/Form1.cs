using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Tekla Structures Namespace References
using Tekla.Structures;
using Tekla.Structures.Model;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;
using System.Collections;

namespace PickPointsAndWorkPlane
{
    public partial class Form1 : Form
    {
        // new model declaration
        Model Model;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            try
            {
                // new model instantiation
                Model = new Model();
            }
            catch 
            {
                // if user is not connected to tekla model
                MessageBox.Show("Please connect to Tekla Structures");
            }
        }

        private void btnPickPoints_Click(object sender, EventArgs e)
        {
            T3D.Point firstPoint = null; // first point picked by user
            T3D.Point secondPoint = null; // second point picked by user

            TSMUI.Picker picker = new TSMUI.Picker(); // picker for user to pick points

            try
            {
                // store picked points in an ArrayList
                ArrayList pickedPoints =  picker.PickPoints(Tekla.Structures.Model.UI.Picker.PickPointEnum.PICK_TWO_POINTS);

                firstPoint = pickedPoints[0] as T3D.Point; // first picked point
                secondPoint = pickedPoints[1] as T3D.Point; // second picked point
            }
            catch // if user cancels without selecting points
            {
                // set both points to null
                firstPoint = null;
                secondPoint = null;

                // inform user that first and second points weren't chosen
                MessageBox.Show("First and second points were not chosen.");
            }
            finally
            {
                // if first and second points aren't null
                if (firstPoint != null && secondPoint != null)
                {
                    // subtract distance between two points
                    T3D.Vector XVector = new T3D.Vector(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y, secondPoint.Z - firstPoint.Z);
                    T3D.Vector YVector = new T3D.Vector(new T3D.Vector(0, 0, -1)); 
                    
                    // use selected points to set work plane
                    Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(firstPoint, XVector, YVector));

                    // commit changes to model
                    Model.CommitChanges();
                }
            }
        }

        private void btnPickPart_Click(object sender, EventArgs e)
        {
            // declaration for object user will select
            ModelObject pickedObject = null;

            // New picker for user interface
            TSMUI.Picker picker = new TSMUI.Picker();

            try
            {
                // if user picks an object
                pickedObject = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT);
            }
            catch
            {
                // if user interrupts
                pickedObject = null;
                MessageBox.Show("No object was selected.");
            }
            finally
            {
                if (pickedObject != null)
                {
                    // get coordinate system for object
                    T3D.CoordinateSystem objectSystem = pickedObject.GetCoordinateSystem();

                    // set transformation plane to picked object coordinate system
                    Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(objectSystem));

                    Model.CommitChanges();
                }
            }


        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {
            // set transformation plane to default transformation plane using empty constructor
            Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane());

            Model.CommitChanges();
        }
    }
}
