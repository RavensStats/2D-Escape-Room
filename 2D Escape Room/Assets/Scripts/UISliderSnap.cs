using UnityEngine;
using UnityEngine.EventSystems;

public class UISliderSnap : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public RectTransform parentRect; // Assign Bedroom_Light_Switch RectTransform
    public RectTransform topLimit;   // Assign TopLimit RectTransform
    public RectTransform bottomLimit; // Assign BottomLimit RectTransform
    public int snapPoints = 11;
    private float[] snapYPositions;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        snapYPositions = new float[snapPoints];
        float top = topLimit.anchoredPosition.y;
        float bottom = bottomLimit.anchoredPosition.y;
        for (int i = 0; i < snapPoints; i++)
        {
            snapYPositions[i] = Mathf.Lerp(bottom, top, i / (float)(snapPoints - 1));
        }
    }

    public void OnBeginDrag(PointerEventData eventData) { }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRect, eventData.position, eventData.pressEventCamera, out localPoint);
        Vector2 anchored = rectTransform.anchoredPosition;
        float minY = Mathf.Min(snapYPositions[0], snapYPositions[snapPoints - 1]);
        float maxY = Mathf.Max(snapYPositions[0], snapYPositions[snapPoints - 1]);
        anchored.y = Mathf.Clamp(localPoint.y, minY, maxY);
        rectTransform.anchoredPosition = new Vector2(anchored.x, anchored.y);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Snap to closest
        float currentY = rectTransform.anchoredPosition.y;
        float minDist = Mathf.Abs(currentY - snapYPositions[0]);
        float closestY = snapYPositions[0];
        for (int i = 1; i < snapPoints; i++)
        {
            float dist = Mathf.Abs(currentY - snapYPositions[i]);
            if (dist < minDist)
            {
                minDist = dist;
                closestY = snapYPositions[i];
            }
        }
        Vector2 anchored = rectTransform.anchoredPosition;
        rectTransform.anchoredPosition = new Vector2(anchored.x, closestY);
    }

    // Returns the index (0-based) of the closest snap point to the current slider position
    public int GetCurrentSnapIndex()
    {
        float currentY = rectTransform.anchoredPosition.y;
        int closestIndex = 0;
        float minDist = Mathf.Abs(currentY - snapYPositions[0]);
        for (int i = 1; i < snapPoints; i++)
        {
            float dist = Mathf.Abs(currentY - snapYPositions[i]);
            if (dist < minDist)
            {
                minDist = dist;
                closestIndex = i;
            }
        }
        return closestIndex;
    }
}
